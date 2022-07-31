using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.BLL.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User item)
        {
            if (item != null)
            {
                _userRepository.Create(item);
                _userRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _userRepository.Delete(id);
            _userRepository.Save();
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(long Id)
        {
            return _userRepository.GetById(Id);
        }
        
        public async Task Update(User item)
        {
           await _userRepository.Update(item);
            _userRepository.Save();
        }
    }
}

