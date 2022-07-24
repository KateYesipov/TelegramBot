using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IUserService
    {
        User GetById(long Id);
        User GetByUserName(string value);
        List<User> GetAll();
        void Update(User item);
        void Create(User item);
        void DeleteById(long id);
    }
}
