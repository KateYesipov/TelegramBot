using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Models.Chats
{
    public class SelectChat
    {
        public long Id { get; set; }
        public long TelegramChatId { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long BotId { get; set; }
        public Bot Bot { get; set; }
        public Message LastMessage { get; set; }
    }
}
