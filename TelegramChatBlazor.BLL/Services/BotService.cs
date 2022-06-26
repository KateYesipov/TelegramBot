using Microsoft.Extensions.DependencyInjection;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.BLL.Services
{
    public class BotService : IBotService
    {
        private readonly IServiceProvider _services;
        private readonly IBackgroundTelegramService _backgroundTelegram;

        private readonly IBotRepository _botRepository;

        public BotService(IBotRepository botRepository, IServiceProvider services, IBackgroundTelegramService backgroundTelegram)
        {
            _botRepository = botRepository;
            _services = services;
            _backgroundTelegram = backgroundTelegram;
        }

        public void Create(Bot item)
        {
            if (item != null)
            {
                item.CreateAt = DateTime.Now;
                _botRepository.Create(item);
                _botRepository.Save();


                using (var scope = _services.CreateScope())
                {
                    var botService = scope.ServiceProvider
                                          .GetRequiredService<IBotService>();
                    _backgroundTelegram.Start(item.Token);
                }
            }
        }

        public void DeleteById(long id)
        {
            _botRepository.Delete(id);
            _botRepository.Save();
        }

        public List<Bot> GetAll()
        {
            return _botRepository.GetAll();
        }

        public Bot GetById(long Id)
        {
            return _botRepository.GetById(Id);
        }

        public Bot GetByUsername(string username)
        {
            return _botRepository.GetByUsername(username);
        }

        public Bot GetByToken(string token)
        {
            return _botRepository.GetByToken(token);
        }

        public void Update(Bot bot)
        {
            _botRepository.Update(bot);
            _botRepository.Save();
        }
    }
}
