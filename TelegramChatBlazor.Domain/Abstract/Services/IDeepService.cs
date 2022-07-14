namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IDeepService
    {
        Task<string> Translate(string text,string langCode);
    }
}
