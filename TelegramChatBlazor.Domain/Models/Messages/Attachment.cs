using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Messages
{
    public class Attachment 
    {
        public string FilePath { get; set; }
        public string Type { get; set; }
        public long MessageId { get; set; }
        public Message Message { get; set; }


        public string FileName { get; set; }
        public Stream Stream { get; set; }
    }
}
