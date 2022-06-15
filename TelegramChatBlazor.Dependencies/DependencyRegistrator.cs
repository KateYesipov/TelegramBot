using TelegramChatBlazor.Dependencies.DependencyModules;
using Microsoft.Extensions.DependencyInjection;
using Jironimo.Dependencies.DependencyModules;

namespace TelegramChatBlazor.Dependencies
{
    public static class DependencyRegistrator
    {
        public static void RegisterDependencyModules(this IServiceCollection services)
        {
            services.RegisterRoutes();
            services.RegisterServices();
        }
    }
}
