using AutoMapper;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.DAL.Repository
{
    public class BotRepository : IBotRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public BotRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Create(Bot item)
        {
            var bot = _mapper.Map<Entities.Bot>(item);
            _context.Bots.Add(bot);
        }

        public void Delete(long id)
        {
            var bot = _context.Bots.Find(id);
            if (bot != null)
                _context.Bots.Remove(bot);
        }

        public List<Bot> GetAll()
        {
            return _mapper.Map<List<Bot>>(_context.Bots);
        }

        public Bot GetById(long id)
        {
            var botEntity = _context.Bots.FirstOrDefault(x => x.Id == id);
            var bot = _mapper.Map<Bot>(botEntity);
            return bot;
        }

        public void Update(Bot bot)
        {
            var botEntity = _mapper.Map<Entities.Bot>(bot);
            _context.Update(botEntity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
