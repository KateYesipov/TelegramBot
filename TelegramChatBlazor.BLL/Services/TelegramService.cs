using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.Text;
using Telegram.Bot;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Settings;

namespace TelegramChatBlazor.BLL.Services
{
    public class TelegramService : ITelegramService
    {
        private readonly IBotService _botService;
        private readonly IMessageRepository _messageRepository;
        private readonly IChatRepository _chatRepository;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly HttpClient _httpclient;
        private readonly TelegramChatBlazorSettings _chatBlazorSettings;

        public TelegramService(IMessageRepository messageRepository,
                               IChatRepository chatRepository,
                               IWebHostEnvironment appEnvironment,
                               IBotService botService,
                               IAppSettingsService appSettingsService,
                               HttpClient httpclient)
        {
            _chatBlazorSettings = appSettingsService.TelegramChatBlazorSettings;
            _messageRepository = messageRepository;
            _appEnvironment = appEnvironment;
            _chatRepository = chatRepository;
            _httpclient = httpclient;
            _botService = botService;
        }

        public List<Chat> GetChatListByBotId(long botId)
        {
            return _chatRepository.GetByBotId(botId);
        }

        public Chat GetChatsByIdIncludeMessages(long Id)
        {
            return _chatRepository.GetById(Id);
        }

        public List<Message> GetMessages(long ChatId)
        {
            return _messageRepository.GetById(ChatId);
        }

        public MessageRequest AddMessage(MessageRequest messageRequest)
        {
            if (messageRequest == null) { return null; }
            var token = messageRequest.Token;
            if (String.IsNullOrEmpty(token)) { return null; }
            var botClient = new TelegramBotClient(token);

            var bot = _botService.GetByToken(messageRequest.Token);

            var chatId = messageRequest.ChatId;
            var chat = _chatRepository.GetById(chatId);
            if (chat == null)
            {
                messageRequest.PartnerAvatar = UploadImageFromTelegram(botClient, messageRequest.PartnerAvatar, "/Images/avatar//").Result;

                var newChat = new Chat
                {
                    Id = chatId,
                    PartnerUserName = messageRequest.PartnerUserName,
                    PartnerName = messageRequest.PartnerName,
                    PartnerLastName = messageRequest.PartnerLastName,
                    PartnerAvatar = messageRequest.PartnerAvatar,
                    BotAvatar = messageRequest.BotAvatar,
                    BotUserName = messageRequest.BotUserName,
                    BotId = bot.Id,
                    Messages = new List<Message> { new Message {Text= messageRequest.Text,
                                                 CreateAt=DateTime.Now,IsPartner=messageRequest.IsPartner }}
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
                    IsPartner = messageRequest.IsPartner,
                    CreateAt = DateTime.Now
                };

                _messageRepository.Create(newMessage);
                _messageRepository.Save();
            }
            return messageRequest;
        }

        public async Task SendMessage(long chatId, string textMessage, string token)
        {
            if (String.IsNullOrEmpty(token)) { }
            var botClient = new TelegramBotClient(token);
            //Db
            var messageRequest = new MessageRequest(token, chatId,
               textMessage, false, "", "", "", "", "", "");

            var url = _chatBlazorSettings.ApiUrl + "api/apimessage";
            var parametrs = new StringContent(JsonConvert.SerializeObject(messageRequest), Encoding.UTF8, "application/json");

            await _httpclient.PostAsync(url, parametrs).ConfigureAwait(false);

            //Telegram send
            await botClient.SendTextMessageAsync(chatId, textMessage);
        }

        private async Task<string> UploadImageFromTelegram(ITelegramBotClient botClient, string fileId, string pathFolder)
        {
            var file = await botClient.GetFileAsync(fileId);
            if (file != null)
            {
                var fileName = pathFolder + Guid.NewGuid() + "_" + file.FilePath.Remove(0, file.FilePath.IndexOf("/") + 1);
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + fileName, FileMode.Create))
                {
                    await botClient.DownloadFileAsync(file.FilePath, fileStream);
                }
                return fileName;
            }
            return null;
        }

        private async Task<string> UploadFileFromTelegram(ITelegramBotClient botClient, string fileId, string pathFolder)
        {
            return "";
        }
    }
}
