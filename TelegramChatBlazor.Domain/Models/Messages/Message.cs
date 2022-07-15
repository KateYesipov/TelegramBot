
using TelegramChatBlazor.Domain.Models.Chats;

namespace TelegramChatBlazor.Domain.Models.Messages
{
    public class Message
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string? TranslatedText { get; set; }
        public bool IsTranslated { get; set; } = false;
        public bool IsPartner { get; set; }
        public DateTime CreateAt { get; set; }
        public long? MessageGroupId { get; set; }
        public string? Type { get; set; }
        public bool IsRead { get; set; }
        public long ChatId { get; set; }
        //public Chat Chat { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
