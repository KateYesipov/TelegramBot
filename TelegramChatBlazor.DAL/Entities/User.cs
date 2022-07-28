using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramChatBlazor.DAL.Entities
{
    public class User 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? AvatarPath { get; set; }
        public string? ColorAvatar { get; set; }
        public string languageCode { get; set; }
        public DateTime CreateAt { get; set; }
        public long UserStatusId { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
