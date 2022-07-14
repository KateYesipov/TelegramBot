using TelegramChatBlazor.Domain.Models.Filters;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IFilterService
    {
        Filter GetById(long Id);
        List<Filter> GetAll();
        void Update(Filter item);
        void Create(Filter item);
        void DeleteById(long id);
    }
}
