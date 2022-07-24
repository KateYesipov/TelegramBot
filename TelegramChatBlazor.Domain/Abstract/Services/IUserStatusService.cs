using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IUserStatusService
    {
        UserStatus GetById(long Id);
        List<UserStatus> GetAll();
        void Update(UserStatus item);
        void Create(UserStatus item);
        void DeleteById(long id);
    }
}
