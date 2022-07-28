namespace TelegramChatBlazor.Domain.Models
{
    public class User 
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? AvatarPath { get; set; }
        public string? ColorAvatar { get; set; }
        public string languageCode { get; set; }
        public DateTime CreateAt { get; set; }
        public long UserStatusId { get; set; }
        public Status UserStatus { get; set; }
    }
}
