using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IChatRepository
    {
        List<Chat> GetAll();
        Chat GetById(long Id);
        void Create(Chat item);
        void Delete(Guid id);
        void Save();
    }
}
