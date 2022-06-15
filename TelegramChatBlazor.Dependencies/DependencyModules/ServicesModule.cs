using TelegramChatBlazor.Domain.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TelegramChatBlazor.Domain.Abstract.Services;

namespace TelegramChatBlazor.Dependencies.DependencyModules
{
    public static class ServicesModule
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.TryAddSingleton<IAppSettingsService, AppSettingsService>();
            services.AddHttpContextAccessor();
        }
    }
}
