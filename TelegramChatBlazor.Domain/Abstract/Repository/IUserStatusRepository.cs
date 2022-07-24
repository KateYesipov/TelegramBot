using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IUserStatusRepository
    {
        UserStatus GetById(long id);
        List<UserStatus> GetAll();
        void Create(UserStatus item);
        void Update(UserStatus item);
        void Delete(long id);
        void Save();
    }
}
