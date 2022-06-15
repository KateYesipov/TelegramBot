using Microsoft.Extensions.Configuration;

namespace TelegramChatBlazor.Domain.Models.Settings
{
    public class TelegramChatBlazorSettings
    {
        public TelegramChatBlazorSettings(IConfiguration configuration)
        {
            IConfigurationSection section = configuration.GetSection("PdfEscapeSettings");
            section.Bind(this);
        }

        public TelegramChatBlazorSettings() { }
    }
}
