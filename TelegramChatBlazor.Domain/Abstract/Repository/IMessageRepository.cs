using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IMessageRepository
    {
        List<Message> GetAll();
        void Create(Message item);
        void Delete(Guid id);
        void Save();
        List<Message> GetById(long chatId);
    }
}
