using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Routing.LocalizedRoute
{
    public class LocalizedRule
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string RuleName { get; set; }
        public string Name { get; set; }
        public bool LangPrefix { get; set; }

        public List<Branch> Branches { get; set; }
        public string MacRedirect { get; set; }
    }
}