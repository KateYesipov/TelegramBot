using DeepL;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Settings;

namespace TelegramChatBlazor.BLL.Services
{
    public class DeepService : IDeepService
    {
        private readonly TelegramChatBlazorSettings _chatBlazorSettings;
        private readonly DeepLClient _deeplClient;
        public DeepService(IAppSettingsService appSettingsService)
        {
            _chatBlazorSettings = appSettingsService.TelegramChatBlazorSettings;
            _deeplClient = new DeepLClient(_chatBlazorSettings.DeeplToken, useFreeApi: false);
        }

        public async Task<string> Translate(string text)
        {
            Translation translation = await _deeplClient.TranslateAsync(
                        text,
                        Language.Russian
                    );
            var DetectedSourceLanguage = translation.DetectedSourceLanguage;
            return translation.Text;
        }
    }
}
