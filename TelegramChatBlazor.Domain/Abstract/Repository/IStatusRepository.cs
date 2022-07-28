using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IStatusRepository
    {
        Status GetById(long id);
        List<UserStatus> GetIncludeUserAll();
        List<Status> GetAll();
        void Create(Status item);
        void Update(Status item);
        void Delete(long id);
        void Save();
    }
}
