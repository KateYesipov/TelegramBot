using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IBotService
    {
        Bot GetById(long Id);
        List<Bot> GetAll();
        void Update(Bot bot);
        void Create(Bot item);
        void DeleteById(long id);
    }
}
