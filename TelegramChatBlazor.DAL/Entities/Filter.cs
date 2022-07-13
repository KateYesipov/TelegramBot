using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.DAL.Entities
{
    public class Filter : Entity<long>
    {
        public string ColorHex { get; set; }
        public bool Readed { get; set; }
        public bool Archived { get; set; }
        public bool Mailing { get; set; }
        public DateTime Created_at { get; set; }
    }
}
