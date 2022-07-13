using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.DAL.Entities
{
    public class Language : Entity<long>
    {
        public string Name { get; set; }
        public string languageCode { get; set; }
    }
}
