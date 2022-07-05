using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface ICategoryRepostitory
    {
        Category GetById(long id);
        List<Category> GetAll();
        void Create(Category item);
        void Delete(long id);
        void Save();
    }
}
