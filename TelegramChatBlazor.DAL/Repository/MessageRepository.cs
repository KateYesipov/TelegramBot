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
            _context.Database.ExecuteSqlRaw(@"Insert into Messages 
           (Text, IsPartner, CreateAt,ChatId,MessageGroupId,IsRead,Type)
           OUTPUT inserted.Id
           Values({0},{1},{2},{3},{4},{5},{6})",
              item.Text ?? "", item.IsPartner, item.CreateAt,
              item.ChatId, item.MessageGroupId,false, item.Type);

            _context.SaveChanges();

            var id = _context.Messages.ToList().LastOrDefault().Id;
            return id;
        }

        public void Delete(long id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
                _context.Messages.Remove(message);
        }

        public List<Message> GetAll()
        {
            var messages = _context.Messages.ToList();
            return _mapper.Map<List<Message>>(messages);
        }

        public List<Message> GetById(long chatId)
        {
            var messages = _context.Messages.Where(x => x.ChatId == chatId).ToList();
            return _mapper.Map<List<Message>>(messages);
        }

        public Message GetByMessageGroupId(long messageGroupId)
        {
            var messages = _context.Messages.FirstOrDefault(x => x.MessageGroupId == messageGroupId);
            return _mapper.Map<Message>(messages);
        }

        public async Task Update(Message item)
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync(@"UPDATE Messages SET  
           IsRead={1}
           WHERE Id={0}",
                  item.Id, item.IsRead);
                await _context.SaveChangesAsync();
            }catch(Exception ex)
            {

            }
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