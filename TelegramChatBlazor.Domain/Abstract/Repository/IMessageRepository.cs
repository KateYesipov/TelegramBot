using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IMessageRepository
    {
        List<Message> GetAll();
        void Create(Message item);
        void Delete(Guid id);
        void Save();
    }
}
