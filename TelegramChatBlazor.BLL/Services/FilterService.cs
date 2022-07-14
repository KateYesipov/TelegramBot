using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Filters;

namespace TelegramChatBlazor.BLL.Services
{
    public class FilterService : IFilterService
    {
        private readonly IFilterRepository _filterRepository;

        public FilterService(IFilterRepository filterRepository)
        {
            _filterRepository = filterRepository;
        }

        public void Create(Filter item)
        {
            if (item != null)
            {
                _filterRepository.Create(item);
                _filterRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _filterRepository.Delete(id);
            _filterRepository.Save();
        }

        public List<Filter> GetAll()
        {
            return _filterRepository.GetAll();
        }

        public Filter GetById(long Id)
        {
            return _filterRepository.GetById(Id);
        }

        public void Update(Filter item)
        {
            _filterRepository.Update(item);
            _filterRepository.Save();
        }
    }
}

