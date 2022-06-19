namespace TelegramChatBlazor.Domain.Models
{
    public class Message
    {
        public string Text { get; set; }
        public bool IsPartner { get; set; }
        public DateTime CreateAt { get; set; }
        public long ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
