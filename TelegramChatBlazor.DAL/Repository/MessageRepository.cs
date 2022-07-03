using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.DAL.Repository
{
    public class MessageRepository : IMessageRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public MessageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Create(Message item)
        {
            _context.Database.ExecuteSqlRaw(@"Insert into Message 
           (Text, IsPartner, CreateAt,ChatId)
           Values({0},{1},{2},{3})",
           item.Text,item.IsPartner, item.CreateAt,
           item.ChatId);
        }

        public void Delete(Guid id)
        {
            var message = _context.Message.Find(id);
            if (message != null)
                _context.Message.Remove(message);
        }

        public List<Message> GetAll()
        {
            var messages = _context.Message.ToList();
            return _mapper.Map<List<Message>>(messages);
        }

        public List<Message> GetById(long chatId)
        {
            var messages = _context.Message.Where(x=>x.ChatId==chatId).ToList();
            return _mapper.Map<List<Message>>(messages);
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