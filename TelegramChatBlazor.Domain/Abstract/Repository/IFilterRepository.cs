using TelegramChatBlazor.Domain.Models.Filters;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IFilterRepository
    {
        Filter GetById(long id);
        List<Filter> GetAll();
        void Create(Filter item);
        void Update(Filter item);
        void Delete(long id);
        void Save();
    }
}
