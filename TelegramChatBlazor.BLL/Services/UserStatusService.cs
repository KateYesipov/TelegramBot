using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.BLL.Services
{
    public class UserStatusService : IUserStatusService
    {
        private readonly IStatusRepository _userStatusRepository;

        public UserStatusService(IStatusRepository userStatusRepository)
        {
            _userStatusRepository = userStatusRepository;
        }

        public List<UserStatus> GetAll()
        {
            return _userStatusRepository.GetIncludeUserAll();
        }
    }
}

