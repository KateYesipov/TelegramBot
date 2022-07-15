using TelegramChatBlazor.Domain.Models.Chats;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface ITelegramService
    {
        public Chat GetChatByIdIncludeMessages(long ChatId);
        public List<Message> GetMessages(long ChatId);
        public MessageRequest AddMessage(MessageRequest message);
        public Task SendMessage(SendMessage sendMessage);
    }
}
