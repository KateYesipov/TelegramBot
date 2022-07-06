using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Messages
{
    public class Attachment 
    {
        public long Id { get; set; }

        public string FilePath { get; set; }
        //public string FileNme { get; set; }
        //public string ContentType { get; set; }
        //public long FileSize { get; set; }
        public long MessageId { get; set; }
        public Message Message { get; set; }

        //public Stream Stream { get; set; }
    }
}
