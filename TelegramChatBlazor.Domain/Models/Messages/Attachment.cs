using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Messages
{
    public class Attachment
    {
        public Stream Stream { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
