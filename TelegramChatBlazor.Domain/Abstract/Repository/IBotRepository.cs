using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IBotRepository
    {
        Bot GetById(long id);
        List<Bot> GetAll();
        void Create(Bot item);
        void Delete(long id);
        void Save();
        void Update(Bot bot);
    }
}
