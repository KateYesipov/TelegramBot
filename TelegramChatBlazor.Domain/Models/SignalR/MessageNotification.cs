using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.SignalR
{
    public class MessageNotification
    {
        public long  Id { get; set; }
        public string Text { get; set; }
        public bool IsPartner { get; set; }
        public DateTime CreateAt { get; set; }
        public long? MessageGroupId { get; set; }
        public string Type { get; set; }
        public long ChatId { get; set; }
        public string FilePath { get; set; }
    }
}
