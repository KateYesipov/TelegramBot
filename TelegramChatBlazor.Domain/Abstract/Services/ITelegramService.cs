using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Api;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface ITelegramService
    {
        public List<Chat> GetChats();
        public Chat GetChatsByIdIncludeMessages(long ChatId);
        public List<Message> GetMessages(long ChatId);
        public MessageRequest AddMessage(MessageRequest message);
        public Task SendMessage(long chatId, string textMessage);
    }
}
