using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IBotService
    {
        Bot GetById(long Id);
        Bot GetByUsername(string username);
        Bot GetByToken(string token);
        List<Bot> GetAll();
        void Update(Bot bot);
        void Create(Bot item);
        void DeleteById(long id);
    }
}
