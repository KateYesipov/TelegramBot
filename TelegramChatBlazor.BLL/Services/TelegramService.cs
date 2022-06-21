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
        private readonly IMessageRepository _messageRepository;
        private readonly IChatRepository _chatRepository;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly HttpClient _httpclient;
        private readonly TelegramChatBlazorSettings _chatBlazorSettings;
        private readonly TelegramBotClient _botClient;

        public TelegramService(IMessageRepository messageRepository,
                               IChatRepository chatRepository,
                               IWebHostEnvironment appEnvironment,
                               IAppSettingsService appSettingsService,
                               HttpClient httpclient)
        {
            _chatBlazorSettings = appSettingsService.TelegramChatBlazorSettings;
            _botClient = new TelegramBotClient(_chatBlazorSettings.BotClient);
            _messageRepository = messageRepository;
            _appEnvironment = appEnvironment;
            _chatRepository = chatRepository;
            _httpclient = httpclient;
        }

        public List<Chat> GetChats()
        {
            return _chatRepository.GetAll();
        }

        public Chat GetChatsByIdIncludeMessages(long Id)
        {
            return _chatRepository.GetById(Id);
        }

        public List<Message> GetMessages(long ChatId)
        {
            return _messageRepository.GetById(ChatId);
        }

        public MessageRequest AddMessage(MessageRequest message)
        {
            var chatId = message.ChatId;
            var chat = _chatRepository.GetById(chatId);
            if (chat == null)
            {
                message.PartnerAvatar = UploadImageFromTelegram(_botClient, message.PartnerAvatar, "/Images/avatar//").Result;

                var newChat = new Chat
                {
                    Id = chatId,
                    PartnerUserName = message.PartnerUserName,
                    PartnerName = message.PartnerName,
                    PartnerLastName = message.PartnerLastName,
                    PartnerAvatar = message.PartnerAvatar,
                    BotAvatar = message.BotAvatar,
                    BotUserName = message.BotUserName,
                    Messages = new List<Message> { new Message {Text= message.Text,
                                                 CreateAt=DateTime.Now,IsPartner=message.IsPartner }}
                };

                _chatRepository.Create(newChat);
                _chatRepository.Save();
            }
            else
            {
                var newMessage = new Message
                {
                    ChatId = chat.Id,
                    Text = message.Text,
                    IsPartner = message.IsPartner,
                    CreateAt = DateTime.Now
                };

                _messageRepository.Create(newMessage);
                _messageRepository.Save();
            }
            return message;
        }

        public async Task SendMessage(long chatId, string textMessage)
        {
            //Db
            var messageRequest = new MessageRequest(chatId,
               textMessage, false, "", "", "", "", "", "");

            var url = "https://localhost:7142/api/apimessage";
            var parametrs = new StringContent(JsonConvert.SerializeObject(messageRequest), Encoding.UTF8, "application/json");

            await _httpclient.PostAsync(url, parametrs).ConfigureAwait(false);

            //Telegram send
            await _botClient.SendTextMessageAsync(chatId, textMessage);
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
    }
}
