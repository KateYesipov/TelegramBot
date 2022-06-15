using Newtonsoft.Json;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Routing;

namespace TelegramChatBlazor.Domain.Concrete
{
    public class ApiRoutesParser : IApiRoutesParser
    {
        private readonly string _routesPaths;
        public ApiRoutesParser(string routesPaths)
        {
            _routesPaths = routesPaths;
        }
        public List<RoutesSet> ParseTelegramChatBlazors()
        {
            List<RoutesSet> routesCollection = new List<RoutesSet>();

            using (StreamReader reader = new StreamReader(string.Format(_routesPaths)))
            {
                string json = reader.ReadToEnd();
                routesCollection.Add(JsonConvert.DeserializeObject<RoutesSet>(json));
            }

            return routesCollection;
        }
    }
}

