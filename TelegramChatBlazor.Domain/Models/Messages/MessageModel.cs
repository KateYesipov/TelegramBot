using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Messages
{
    public class MessageModel
    {
        public string Text { get; set; }
        public bool IsPartner { get; set; }
        public DateTime CreateAt { get; set; }
        public string? FilePath { get; set; }
        public long? MessageGroupId { get; set; }
        public string? Type { get; set; }
    }
}
