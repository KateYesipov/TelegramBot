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

        public long Create(Message item)
        {
            _context.Database.ExecuteSqlRaw(@"Insert into Message 
           (Text, IsPartner, CreateAt,ChatId,MessageGroupId,IsRead,Type)
           OUTPUT inserted.Id
           Values({0},{1},{2},{3},{4},{5},{6})",
              item.Text ?? "", item.IsPartner, item.CreateAt,
              item.ChatId, item.MessageGroupId,false, item.Type);

            _context.SaveChanges();

            var id = _context.Message.ToList().LastOrDefault().Id;
            return id;
        }

        public void Delete(long id)
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
            var messages = _context.Message.Where(x => x.ChatId == chatId).ToList();
            return _mapper.Map<List<Message>>(messages);
        }

        public Message GetByMessageGroupId(long messageGroupId)
        {
            var messages = _context.Message.FirstOrDefault(x => x.MessageGroupId == messageGroupId);
            return _mapper.Map<Message>(messages);
        }

        public void Update(Message item)
        {
            _context.Database.ExecuteSqlRaw(@"UPDATE Message SET  
           Text={1}, IsPartner={2}, CreateAt={3},ChatId={4},MessageGroupId={5},IsRead={6},Type={7}
           WHERE Id={0}",
             item.Id,item.Text ?? "", item.IsPartner, item.CreateAt,
             item.ChatId, item.MessageGroupId, item.IsRead, item.Type);
            _context.SaveChanges();
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