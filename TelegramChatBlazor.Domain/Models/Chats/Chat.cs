using TelegramChatBlazor.Domain.Models.Messages;
namespace TelegramChatBlazor.Domain.Models.Chats
{
    public class Chat
    {
        public long Id { get; set; }
        public long TelegramChatId { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long BotId { get; set; }
        public Bot Bot { get; set; }
        public List<Message> Messages { get; set; }
        public Chat()
        {
            Messages = new List<Message>();
        }
    }
}