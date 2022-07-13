using TelegramChatBlazor.Domain.Models.Messages;
namespace TelegramChatBlazor.Domain.Models.Chats
{
    public class Chat
    {
        public long Id { get; set; }
        public long TelegramChatId { get; set; }
        public string? PartnerAvatar { get; set; }
        public string? PartnerUserName { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerLastName { get; set; }
        public string BotUserName { get; set; }
        public string? BotAvatar { get; set; }
        public string languageCode { get; set; }
        public long BotId { get; set; }
        public Bot Bot { get; set; }
        public List<Message> Messages { get; set; }
        public Chat()
        {
            Messages = new List<Message>();
        }
    }
}