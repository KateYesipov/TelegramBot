﻿namespace TelegramChatBlazor.DAL.Entities
{
    public class Filter : Entity<long>
    {
        public string Name { get; set; }
        public string ColorHex { get; set; }
        public bool? Readed { get; set; }
        public bool? Archived { get; set; }
        public bool? Mailing { get; set; }
        public DateTime Created_at { get; set; }
    }
}
