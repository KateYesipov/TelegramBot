using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IUserService
    {
        User GetById(long Id);
        List<User> GetAll();
        Task Update(User item);
        void Create(User item);
        void DeleteById(long id);
    }
}
