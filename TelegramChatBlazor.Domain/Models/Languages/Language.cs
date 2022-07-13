using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Languages
{
    public class Language
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string languageCode { get; set; }
    }
}
