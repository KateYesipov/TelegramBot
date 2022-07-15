using TelegramChatBlazor.Domain.Models.Chats;
using TelegramChatBlazor.Domain.Models.Filters;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IChatService
    {
        public List<SelectChat> GetChatListByBotId(long botId, Filter filter);
    }
}
