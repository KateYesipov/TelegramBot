using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Chats;

namespace TelegramChatBlazor.DAL.Repository
{
    public class ChatRepository : IChatRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public ChatRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Create(Chat item)
        {
            var chat = _mapper.Map<Entities.Chat>(item);
            _context.Chat.Add(chat);
        }

        public void Delete(Guid id)
        {
            var chat = _context.Chat.Find(id);
            if (chat != null)
                _context.Chat.Remove(chat);
        }

        public Chat GetById(long Id)
        {
            var chat = _mapper.Map<Chat>(_context.Chat.Include(m=>m.Messages).Include(x=>x.Bot).FirstOrDefault(x => x.Id == Id));
            return _mapper.Map<Chat>(chat);
        }

        public List<Chat> GetByBotId(long botId)
        {
            return _mapper.Map<List<Chat>>(_context.Chat.Include(m=>m.Messages).Where(x=>x.BotId==botId).ToList());
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