using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Routing.ApiRoute
{
    public class Rule
    {
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public List<string> Languages { get; set; }
        public string Url { get; set; }
        public string Redirect { get; set; }
        public string MacRedirect { get; set; }
    }
}