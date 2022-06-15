using TelegramChatBlazor.Domain.Models.Settings;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IAppSettingsService
    {
        AppSettings GetSettings { get; }
        TelegramChatBlazorSettings TelegramChatBlazorSettings { get; }

    }
}
