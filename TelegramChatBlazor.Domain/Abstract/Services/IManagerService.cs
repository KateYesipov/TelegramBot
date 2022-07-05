using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models.Managers;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IManagerService
    {
        Manager GetById(long Id);
        List<Manager> GetAll();
        void Update(Manager item);
        void Create(Manager item);
        void DeleteById(long id);
    }
}
