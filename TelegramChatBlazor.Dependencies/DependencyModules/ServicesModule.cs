using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Concrete;
using TelegramChatBlazor.DAL.Repository;
using TelegramChatBlazor.BLL.Services;

namespace TelegramChatBlazor.Dependencies.DependencyModules
{
    public static class ServicesModule
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.TryAddSingleton<IAppSettingsService, AppSettingsService>();      
            services.AddTransient<IHasher, Hasher>();
            services.AddHttpClient<IBackgroundTelegramService, BackgroundTelegramService>();
            services.AddTransient<IChatRepository, ChatRepository>();
            services.AddHttpClient<ITelegramService, TelegramService>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IBotRepository, BotRepository>();
            services.AddScoped<IBotService, BotService>();

            services.AddTransient<IColorRepository, ColorRepository>();
            services.AddScoped<IColorService, ColorService>();

            services.AddSignalR();
            services.TryAddSingleton<IAppSettingsService, AppSettingsService>();
            services.AddHttpContextAccessor();
        }
    }
}
