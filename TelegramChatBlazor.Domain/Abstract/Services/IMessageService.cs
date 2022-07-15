using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IMessageService
    {
        List<Message> GetByChatId(long Id);
        List<Message> GetAll();
        void Update(Message item);
        void Create(Message item);
        void DeleteById(long id);
    }
}
