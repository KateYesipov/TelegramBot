using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IAttachmentRepository
    {
        Attachment GetById(long id);
        List<Attachment> GetAll();
        void Create(Attachment item);
        void Update(Attachment item);
        void Delete(long id);
        void Save();
    }
}