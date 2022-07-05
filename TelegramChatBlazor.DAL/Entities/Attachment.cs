using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.DAL.Entities
{
    public class Attachment : Entity<long>
    {
        public string FileNme { get; set; }
        public string ContentType { get; set; }
        public long FileSize { get; set; }
        public long MessageId { get; set; }
        public Message Message { get; set; }
    }
}
