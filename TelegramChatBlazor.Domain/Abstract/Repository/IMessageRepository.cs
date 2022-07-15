using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IMessageRepository
    {
        List<Message> GetAll();
        long Create(Message item);
        void Update(Message item);
        void Delete(long id);
        void Save();
        List<Message> GetById(long chatId);
        Message GetByMessageGroupId(long messageGroupId);
    }
}
