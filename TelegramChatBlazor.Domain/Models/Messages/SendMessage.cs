using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TelegramChatBlazor.Domain.Models.Messages
{
    public class SendMessage
    {
        public long ChatId { get; set; }
        public string Token { get; set; }
        public string TextMessage { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
