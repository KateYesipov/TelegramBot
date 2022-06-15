using TelegramChatBlazor.Domain.Models.Settings;
using Microsoft.Extensions.Configuration;
using TelegramChatBlazor.Domain.Abstract.Services;

namespace TelegramChatBlazor.Dependencies.DependencyModules
{
    public class AppSettingsService : IAppSettingsService
    {
        public AppSettings GetSettings { get; }

        public TelegramChatBlazorSettings TelegramChatBlazorSettings { get; }


        public AppSettingsService(IConfiguration configuration)
        {
            GetSettings = new AppSettings();
            TelegramChatBlazorSettings = new TelegramChatBlazorSettings(configuration);
            configuration.GetSection("GlobalSettings").Bind(GetSettings);

        }
    }
}
