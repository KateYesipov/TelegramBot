using DeepL;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Settings;

namespace TelegramChatBlazor.BLL.Services
{
    public class DeepService : IDeepService
    {
        private readonly TelegramChatBlazorSettings _chatBlazorSettings;
        private readonly Translator _translator;
        public DeepService(IAppSettingsService appSettingsService)
        {
            _chatBlazorSettings = appSettingsService.TelegramChatBlazorSettings;
            _translator = new Translator(_chatBlazorSettings.DeeplToken);
        }

        public async Task<string> Translate(string text, string langCode)
        {
            var translated = await _translator.TranslateTextAsync(text, langCode, LanguageCode.Russian);
            var detectedSourceLanguageCode = translated.DetectedSourceLanguageCode;
            return translated.Text;
        }
    }
}
