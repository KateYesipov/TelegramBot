using AutoMapper;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Chats;

namespace TelegramChatBlazor.BLL.Services
{
    public class ChatService: IChatService
    {
        protected readonly IMapper _mapper;
        private readonly IChatRepository _chatRepository;

        public ChatService(IChatRepository chatRepository, IMapper mapper)
        {
            _chatRepository = chatRepository;
            _mapper = mapper;
        }

        public List<SelectChat> GetChatListByBotId(long botId)
        {
            var chats = _chatRepository.GetByBotId(botId);
            var selectChat = _mapper.Map<List<SelectChat>>(chats);
            foreach (var item in selectChat)
            {
                item.LastMessage = chats.FirstOrDefault(x => x.Id == item.Id).Messages.LastOrDefault();
            }
            return selectChat;
        }
    }
}
