using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Routing;

namespace TelegramChatBlazor.Domain.Concrete
{
    public class RoutesMapper : IRoutesMapper
    {
        private readonly static List<string> _sortRoutes = new List<string> { "en", "fr", "de", "it" };

        public void MapRoutes(List<RoutesSet> routesCollection, IEndpointRouteBuilder builder)
        {
            var routesRules = routesCollection.SelectMany(x => x.Rules);

            foreach (var routeRule in routesRules)
            {
                routeRule.Languages.Sort((i, j) => _sortRoutes.IndexOf(i) > _sortRoutes.IndexOf(j) ? 1 : -1);
                builder.MapControllerRoute(routeRule.Name + "NoLang",
                    routeRule.Url,
                    new
                    {
                        routeName = routeRule.Name,
                        controller = routeRule.Controller,
                        action = routeRule.Action,
                        lang = "en",
                        languages = routeRule.Languages,
                        macRedirect = routeRule.MacRedirect
                    }, new { lang = @"^[a-zA-Z]{2}" });

                foreach (var routeLang in routeRule.Languages)
                {
                    builder.MapControllerRoute(routeRule.Name,
                        $"{routeLang}/" + routeRule.Url,
                        new
                        {
                            routeName = routeRule.Name,
                            controller = routeRule.Controller,
                            action = routeRule.Action,
                            lang = routeLang,
                            languages = routeRule.Languages,
                            macRedirect = routeRule.MacRedirect
                        }, new { lang = @"^[a-zA-Z]{2}" });

                }
            }
        }
    }
}