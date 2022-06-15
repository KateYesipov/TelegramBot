using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;


namespace TelegramChatBlazor.BLL.Services
{
    public class TelegramService : ITelegramService
    {
        private readonly IMessageRepository _messageRepository;

        public TelegramService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public List<Domain.Models.Message> GetChat()
        {
            return _messageRepository.GetAll();
        }      
    }
}
