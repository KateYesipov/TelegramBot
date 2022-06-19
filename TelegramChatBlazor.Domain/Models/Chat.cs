namespace TelegramChatBlazor.Domain.Models
{
    public class Chat
    {
        public long Id { get; set; }
        public string? PartnerAvatar { get; set; }
        public string? PartnerUserName { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerLastName { get; set; }
        public string BotUserName { get; set; }
        public string? BotAvatar { get; set; }
        public List<Message> Messages { get; set; }
        public Chat()
        {
            Messages = new List<Message>();
        }
    }
}