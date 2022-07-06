namespace TelegramChatBlazor.DAL.Entities
{
    public class Message : Entity<long>
    {
        public string? Text { get; set; }
        public bool IsPartner { get; set; }
        public DateTime CreateAt { get; set; }
        public long? MessageGroupId { get; set; }
        public string? Type { get; set; }
        public long ChatId { get; set; }
        public Chat Chat { get; set; }
        public List<Attachment> Attachments { get; set; }
        public Message()
        {
            Attachments = new List<Attachment>();
        }
    }
}
