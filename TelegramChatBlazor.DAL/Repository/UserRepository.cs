using AutoMapper;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.DAL.Repository
{
    public class UserRepository: IUserRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<User> GetAll()
        {
            var user = _context.Users.ToList();
            return _mapper.Map<List<User>>(user);
        }

        public void Create(User item)
        {
            var user = _mapper.Map<Entities.User>(item);
            _context.Users.Add(user);
        }

        public void Delete(long id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
                _context.Users.Remove(user);
        }

        public User GetById(long Id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<User>(user);
        }

        public void Update(User item)
        {
            // _context.Database.ExecuteSqlRaw(@"UPDATE Answers SET  
            // ShortName={1}, FullAnswer={2},CreatedAt={3},CategoryId={4}
            // WHERE Id={0}",
            //item.Id, item.ShortName, item.FullAnswer, item.CreatedAt, item.CategoryId);
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


