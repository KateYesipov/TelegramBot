using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IUserRepository
    {
        User GetById(long id);
        List<User> GetAll();
        void Create(User item);
        void Update(User item);
        void Delete(long id);
        void Save();
    }
}
