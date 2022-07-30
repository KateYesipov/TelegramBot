using TelegramChatBlazor.Domain.Models.Chats;
using TelegramChatBlazor.Domain.Models.Filters;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IChatRepository
    {
        List<Chat> GetByBotId(long botId);
        List<Chat> GetAll();
        Chat GetById(long chatId);
        void Create(Chat item);
        void Delete(Guid id);
        void Save();
    }
}
