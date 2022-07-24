using TelegramChatBlazor.Dependencies.DependencyModules;
using Microsoft.Extensions.DependencyInjection;

namespace TelegramChatBlazor.Dependencies
{
    public static class DependencyRegistrator
    {
        public static void RegisterDependencyModules(this IServiceCollection services)
        {
            services.RegisterServices();
        }
    }
}
