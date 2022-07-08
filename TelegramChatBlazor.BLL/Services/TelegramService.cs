using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Chats;
using TelegramChatBlazor.Domain.Models.Messages;
using TelegramChatBlazor.Domain.Models.Settings;

namespace TelegramChatBlazor.BLL.Services
{
    public class TelegramService : ITelegramService
    {
        private readonly IBotService _botService;
        private readonly IMessageRepository _messageRepository;
        private readonly IAttachmentRepository _attachmentRepository;
        private readonly IChatRepository _chatRepository;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly HttpClient _httpclient;
        private readonly TelegramChatBlazorSettings _chatBlazorSettings;

        public TelegramService(IMessageRepository messageRepository,
                               IChatRepository chatRepository,
                               IWebHostEnvironment appEnvironment,
                               IBotService botService,
                               IAttachmentRepository attachmentRepository,
                               IAppSettingsService appSettingsService,
                               HttpClient httpclient)
        {
            _chatBlazorSettings = appSettingsService.TelegramChatBlazorSettings;
            _messageRepository = messageRepository;
            _appEnvironment = appEnvironment;
            _chatRepository = chatRepository;
            _httpclient = httpclient;
            _botService = botService;
            _attachmentRepository = attachmentRepository;
        }

        public List<Chat> GetChatListByBotId(long botId)
        {
            return _chatRepository.GetByBotId(botId);
        }

        public Chat GetChatByIdIncludeMessages(long Id)
        {
            var chat = _chatRepository.GetById(Id);
            return chat;
        }

        public List<Message> GetMessages(long ChatId)
        {
            return _messageRepository.GetById(ChatId);
        }

        public MessageRequest AddMessage(MessageRequest messageRequest)
        {
            if (messageRequest == null) { throw new Exception("messageRequest null"); }
            var token = messageRequest.Token;
            if (String.IsNullOrEmpty(token)) { throw new Exception("token null"); }


            var botClient = new TelegramBotClient(token);
            var bot = _botService.GetByToken(messageRequest.Token);

            string FilePath = null;
            if (messageRequest.FileId != null && messageRequest.Type == "Photo")
            {
                FilePath = SaveImageFromTelegram(botClient, messageRequest.FileId, "/Images/files//").Result;

                messageRequest.FileId = FilePath;
            }

            if (messageRequest.MessageGroupId > 0)
            {
                var messagesId = _messageRepository.GetByMessageGroupId(messageRequest.MessageGroupId)?.Id;
                if (messagesId != null)
                {
                    var attachment = new Attachment
                    {
                        FilePath = FilePath,
                        MessageId = (long)messagesId,
                        Type = messageRequest.Type
                    };
                    _attachmentRepository.Create(attachment);
                    _attachmentRepository.Save();
                    return messageRequest;
                }
            }

            var chatId = messageRequest.ChatId;
            var chat = _chatRepository.GetById(chatId);
            if (chat == null)
            {
                messageRequest.PartnerAvatar = SaveImageFromTelegram(botClient, messageRequest.PartnerAvatar, "/Images/avatar//").Result;

                var attachments = !String.IsNullOrWhiteSpace(FilePath) ? new List<Attachment>(){ new Attachment
                                          {
                                              FilePath = FilePath,
                                              Type = messageRequest.Type,
                                          }} : new List<Attachment>();

                var newChat = new Chat
                {
                    Id = chatId,
                    TelegramChatId = messageRequest.TelegramChatId,
                    PartnerUserName = messageRequest.PartnerUserName,
                    PartnerName = messageRequest.PartnerName,
                    PartnerLastName = messageRequest.PartnerLastName,
                    PartnerAvatar = messageRequest.PartnerAvatar,
                    BotAvatar = messageRequest.BotAvatar,
                    BotUserName = messageRequest.BotUserName,
                    BotId = bot.Id,
                    Messages = new List<Message> { new Message { Text = messageRequest.Text,
                        CreateAt = DateTime.Now,
                        IsPartner = messageRequest.IsPartner,
                        Type=messageRequest.Type,
                        MessageGroupId = messageRequest.MessageGroupId,
                        Attachments=attachments }}
                };

                _chatRepository.Create(newChat);
                _chatRepository.Save();
            }
            else
            {
                var newMessage = new Message
                {
                    ChatId = chat.Id,
                    Text = messageRequest.Text,
                    Type = messageRequest.Type,
                    IsPartner = messageRequest.IsPartner,
                    CreateAt = DateTime.Now,
                    MessageGroupId = messageRequest.MessageGroupId,
                };

                var messageId = _messageRepository.Create(newMessage);

                if (FilePath != null)
                {
                    var attachment = new Attachment
                    {
                        FilePath = FilePath,
                        Type = messageRequest.Type,
                        MessageId = messageId
                    };
                    _attachmentRepository.Create(attachment);
                    _attachmentRepository.Save();
                }
            }
            return messageRequest;
        }

        public async Task SendMessage(SendMessage sendMessage)
        {
            if (String.IsNullOrEmpty(sendMessage.Token)) { throw new Exception("token null"); }
            var botClient = new TelegramBotClient(sendMessage.Token);

            //Telegram send
            if (!String.IsNullOrWhiteSpace(sendMessage.TextMessage))
            {
                await botClient.SendTextMessageAsync(sendMessage.TelegramChatId, sendMessage.TextMessage);
            }

            //send Photo
            var file = new List<Telegram.Bot.Types.IAlbumInputMedia>();
            foreach (var item in sendMessage.Attachments)
            {
                 file.Add(new Telegram.Bot.Types.InputMediaPhoto(new Telegram.Bot.Types.InputMedia(item.Stream, item.FileName)));

                //var file = new InputOnlineFile(item.Stream, item.FileName);
                //var message = (await botClient.SendPhotoAsync(sendMessage.TelegramChatId, file));
                //if (message.Photo != null)
                //{
                //    sendMessage.FileId = (await botClient.GetFileAsync(message.Photo[message.Photo.Count() - 1].FileId)).FileId;
                //}

                //var file = new InputOnlineFile();
                //await botClient.SendDocumentAsync(chatId, file);
            }
            var sendMessages = (await botClient.SendMediaGroupAsync(sendMessage.TelegramChatId, file));
            foreach (var item in sendMessages)
            {
                if (item.Photo != null)
                {
                    sendMessage.FileId = (await botClient.GetFileAsync(item.Photo[item.Photo.Count() - 1].FileId)).FileId;
                }
            }


            //Api
            var messageRequest = new MessageRequest(sendMessage.Token, sendMessage.ChatId, sendMessage.TelegramChatId,
            sendMessage.TextMessage, false, "", "", "", "", "", "", sendMessage.FileId, 0, sendMessage.Type);

            var url = _chatBlazorSettings.ApiUrl + "api/apimessage";
            var parametrs = new StringContent(JsonConvert.SerializeObject(messageRequest), Encoding.UTF8, "application/json");

            await _httpclient.PostAsync(url, parametrs).ConfigureAwait(false);
        }

        private async Task<string> SaveImageFromTelegram(ITelegramBotClient botClient, string fileId, string pathFolder)
        {
            var file = await botClient.GetFileAsync(fileId);
            if (file != null)
            {
                var PathFile = pathFolder + Guid.NewGuid() + "_" + file.FilePath.Remove(0, file.FilePath.IndexOf("/") + 1);
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + PathFile, FileMode.Create))
                {
                    await botClient.DownloadFileAsync(file.FilePath, fileStream);
                }
                return PathFile;
            }
            return null;
        }

        private async Task<string> UploadFileToTelegram(ITelegramBotClient botClient, string file, string pathFolder)
        {
            return "";
        }
    }
}
