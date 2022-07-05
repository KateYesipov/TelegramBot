using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IAttachmentService
    {
        Attachment GetById(long Id);
        List<Attachment> GetAll();
        void Update(Attachment item);
        void Create(Attachment item);
        void DeleteById(long id);
    }
}
