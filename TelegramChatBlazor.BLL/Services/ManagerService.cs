using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Managers;

namespace TelegramChatBlazor.BLL.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerRepostitory;

        public ManagerService(IManagerRepository managerRepostitory)
        {
            _managerRepostitory = managerRepostitory;
        }

        public void Create(Manager item)
        {
            if (item != null)
            {
                item.CreateAt = DateTime.Now;
                _managerRepostitory.Create(item);
                _managerRepostitory.Save();
            }
        }

        public void DeleteById(long id)
        {
            _managerRepostitory.Delete(id);
            _managerRepostitory.Save();
        }

        public List<Manager> GetAll()
        {
            return _managerRepostitory.GetAll();
        }

        public Manager GetById(long Id)
        {
            return _managerRepostitory.GetById(Id);
        }


        public void Update(Manager item)
        {
            _managerRepostitory.Update(item);
            _managerRepostitory.Save();
        }
    }
}


