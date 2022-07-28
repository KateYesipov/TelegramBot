using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.BLL.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _userStatusRepository;

        public StatusService(IStatusRepository userStatusRepository)
        {
            _userStatusRepository = userStatusRepository;
        }

        public void Create(Status item)
        {
            if (item != null)
            {
                _userStatusRepository.Create(item);
                _userStatusRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _userStatusRepository.Delete(id);
            _userStatusRepository.Save();
        }

        public List<Status> GetAll()
        {
            return _userStatusRepository.GetAll();
        }

        public Status GetById(long Id)
        {
            return _userStatusRepository.GetById(Id);
        }

        public void Update(Status item)
        {
            _userStatusRepository.Update(item);
            _userStatusRepository.Save();
        }
    }
}

