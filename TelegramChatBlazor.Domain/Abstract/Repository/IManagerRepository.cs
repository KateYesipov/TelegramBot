using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models.Managers;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IManagerRepository
    {
        Manager GetById(long id);
        List<Manager> GetAll();
        void Create(Manager item);
        void Delete(long id);
        void Save();
    }
}
