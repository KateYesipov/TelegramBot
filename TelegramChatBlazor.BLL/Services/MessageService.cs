using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.BLL.Services
{
    public class MessageService: IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void Create(Message item)
        {
            if (item != null)
            {
                item.CreateAt = DateTime.Now;
                _messageRepository.Create(item);
                _messageRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _messageRepository.Delete(id);
            _messageRepository.Save();
        }

        public List<Message> GetAll()
        {
            return _messageRepository.GetAll();
        }

        public List<Message> GetByChatId(long Id)
        {
            return _messageRepository.GetById(Id);
        }


        public async Task Update(Message item)
        {
            await _messageRepository.Update(item);
        }
    }
}
