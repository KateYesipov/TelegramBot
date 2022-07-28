using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IStatusService
    {
        Status GetById(long Id);
        List<Status> GetAll();
        void Update(Status item);
        void Create(Status item);
        void DeleteById(long id);
    }
}
