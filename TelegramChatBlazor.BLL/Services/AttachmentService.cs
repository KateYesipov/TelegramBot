using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.BLL.Services
{
    public class AttachmentService : IAttachmentService
    {
        private readonly IAttachmentRepository _attachmentRepository;

        public AttachmentService(IAttachmentRepository attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
        }

        public void Create(Attachment item)
        {
            if (item != null)
            {
                _attachmentRepository.Create(item);
                _attachmentRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _attachmentRepository.Delete(id);
            _attachmentRepository.Save();
        }

        public List<Attachment> GetAll()
        {
            return _attachmentRepository.GetAll();
        }

        public Attachment GetById(long Id)
        {
            return _attachmentRepository.GetById(Id);
        }


        public void Update(Attachment item)
        {
            _attachmentRepository.Update(item);
            _attachmentRepository.Save();
        }
    }
}
