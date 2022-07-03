using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IChatRepository
    {
        public List<Chat> GetByBotId(long botId);
        Chat GetById(long chatId);
        void Create(Chat item);
        void Delete(Guid id);
        void Save();
    }
}
