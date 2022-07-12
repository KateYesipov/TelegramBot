using Microsoft.Extensions.Configuration;

namespace TelegramChatBlazor.Domain.Models.Settings
{
    public class TelegramChatBlazorSettings
    {
        public TelegramChatBlazorSettings(IConfiguration configuration)
        {
            IConfigurationSection section = configuration.GetSection("TelegramChatBlazorSettings");
            section.Bind(this);
        }

        public TelegramChatBlazorSettings() { }

        public string? BaseUrl { get; set; }

        public string? ApiUrl { get; set; }

        public string? DeeplToken { get; set; }
    }
}
