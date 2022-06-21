using TelegramChatBlazor.Domain.Concrete;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using TelegramChatBlazor.Domain.Abstract.Services;

namespace Jironimo.Dependencies.DependencyModules
{
    public static class RoutesModule
    {
        public static void RegisterRoutes(this IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => { options.AppendTrailingSlash = true; });
            services.AddTransient<IRoutesParser>(servicesProvider => new RoutesParser(Path.Combine("Routes", "routes.json")));
            services.AddTransient<ILocalizedRoutesParser>(servicesProvider => new LocalizedRoutesParser(Path.Combine("Routes", "localized-routes.json")));
            services.AddTransient<IApiRoutesParser>(servicesProvider => new ApiRoutesParser(Path.Combine("Routes", "api-routes.json")));
            services.AddTransient<IRoutesMapper, RoutesMapper>(); var buildServiceProvider = services.BuildServiceProvider();
            services.AddTransient<IRoutesConfigurator>(serviceProvider =>
                new RoutesConfigurator(buildServiceProvider.GetService<IRoutesMapper>(), buildServiceProvider.GetService<IRoutesParser>()));
        }
    }
}
