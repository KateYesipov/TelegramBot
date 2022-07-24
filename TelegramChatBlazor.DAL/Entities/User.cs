﻿namespace TelegramChatBlazor.DAL.Entities
{
    public class User : Entity<long>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; }
        public string? AvatarPath { get; set; }
        public string? ColorAvatar { get; set; }
        public string languageCode { get; set; }
        public DateTime CreateAt { get; set; }
        public long UserStatusId { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
