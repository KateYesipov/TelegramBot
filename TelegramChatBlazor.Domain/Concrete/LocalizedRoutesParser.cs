using Newtonsoft.Json;
using System.Text;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Routing.LocalizedRoute;

namespace TelegramChatBlazor.Domain.Concrete
{
    public class LocalizedRoutesParser : ILocalizedRoutesParser
    {
        private readonly string _routesPaths;
        public LocalizedRoutesParser(string routesPaths)
        {
            _routesPaths = routesPaths;
        }
        public LocalizedRulesRoot ParseTelegramChatBlazors()
        {
            LocalizedRulesRoot rules;

            using (StreamReader reader = new StreamReader(string.Format(_routesPaths), Encoding.GetEncoding("iso-8859-1")))
            {
                string json = reader.ReadToEnd();
                rules = JsonConvert.DeserializeObject<LocalizedRulesRoot>(json);
            }

            return rules;
        }
    }
}