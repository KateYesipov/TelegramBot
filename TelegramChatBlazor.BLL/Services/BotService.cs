using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.BLL.Services
{
    public class BotService : IBotService
    {
        private readonly IBotRepository _botRepository;

        public BotService(IBotRepository botRepository)
        {
            _botRepository = botRepository;
        }

        public void Create(Bot item)
        {
            if (item != null)
            {
                item.CreateAt = DateTime.Now;
                _botRepository.Create(item);
                _botRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _botRepository.Delete(id);
            _botRepository.Save();
        }
   
        public List<Bot> GetAll()
        {
          return  _botRepository.GetAll();
        }

        public Bot GetById(long Id)
        {
            return _botRepository.GetById(Id);
        }

        public void Update(Bot bot)
        {
            _botRepository.Update(bot);
            _botRepository.Save();
        }
    }
}
