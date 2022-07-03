using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface ITelegramService
    {
        public List<Chat> GetChatListByBotId(long botId);
        public Chat GetChatsByIdIncludeMessages(long ChatId);
        public List<Message> GetMessages(long ChatId);
        public MessageRequest AddMessage(MessageRequest message);
        public Task SendMessage(SendMessage sendMessage);
    }
}
