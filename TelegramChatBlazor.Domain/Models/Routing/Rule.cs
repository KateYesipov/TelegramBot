using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Routing
{
    public class Rule
    {
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Url { get; set; }
    }
}
