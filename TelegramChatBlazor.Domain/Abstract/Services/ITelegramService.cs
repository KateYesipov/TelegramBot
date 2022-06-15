namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface ITelegramService
    {
        public List<Domain.Models.Message> GetChat();

    }
}
