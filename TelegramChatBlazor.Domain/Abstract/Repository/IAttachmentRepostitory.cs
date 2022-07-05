using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IAttachmentRepostitory
    {
        Attachment GetById(long id);
        List<Attachment> GetAll();
        void Create(Attachment item);
        void Delete(long id);
        void Save();
    }
}
