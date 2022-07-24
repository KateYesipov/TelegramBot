using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.BLL.Services
{
    internal class UserStatusService : IUserStatusService
    {
        private readonly IUserStatusRepository _userStatusRepository;

        public UserStatusService(IUserStatusRepository userStatusRepository)
        {
            _userStatusRepository = userStatusRepository;
        }

        public void Create(UserStatus item)
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

        public List<UserStatus> GetAll()
        {
            return _userStatusRepository.GetAll();
        }

        public UserStatus GetById(long Id)
        {
            return _userStatusRepository.GetById(Id);
        }

        public void Update(UserStatus item)
        {
            _userStatusRepository.Update(item);
            _userStatusRepository.Save();
        }
    }
}

