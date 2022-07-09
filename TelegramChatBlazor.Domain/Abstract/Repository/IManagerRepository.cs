using TelegramChatBlazor.Domain.Models.Managers;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IManagerRepository
    {
        Manager GetById(long id);
        List<Manager> GetAll();
        void Create(Manager item);
        void Update(Manager item);
        void Delete(long id);
        void Save();
    }
}
