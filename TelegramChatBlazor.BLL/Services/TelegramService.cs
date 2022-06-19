using Newtonsoft.Json;
using System.Net;
using System.Text;
using Telegram.Bot;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.SignalR;

namespace TelegramChatBlazor.BLL.Services
{
    public class TelegramService : ITelegramService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IChatRepository _chatRepository;
        private readonly HttpClient _httpclient;

        private static readonly TelegramBotClient botClient = new TelegramBotClient("5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8");

        public TelegramService(IMessageRepository messageRepository,
                               IChatRepository chatRepository,
                                HttpClient httpclient)
        {
            _messageRepository = messageRepository;
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

        public void AddMessage(MessageRequest message)
        {
            var chatId = message.ChatId;
            var chat = _chatRepository.GetById(chatId);
            if (chat == null)
            {
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
            await botClient.SendTextMessageAsync(chatId, textMessage);
        }
    }
}
