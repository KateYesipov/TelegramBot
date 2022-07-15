using TelegramChatBlazor.Domain.Models.Chats;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IChatService
    {
        public List<SelectChat> GetChatListByBotId(long botId);
    }
}
