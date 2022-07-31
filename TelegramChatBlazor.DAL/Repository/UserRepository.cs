using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
            var user = _context.Users.Include(x=>x.UserStatus).ToList();
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

        public User GetByUserName(string value)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == value);
            return _mapper.Map<User>(user);
        }

        public async Task Update(User item)
        {
           await _context.Database.ExecuteSqlRawAsync(@"UPDATE Users SET  
             FirstName={1}, LastName={2},UserName={3},AvatarPath={4},ColorAvatar={5},languageCode={6},UserStatusId={7}
             WHERE Id={0}",
           item.Id, item.FirstName, item.LastName, item.UserName, item.AvatarPath, item.ColorAvatar, item.languageCode, item.UserStatusId);

            var user = _context.Users.FirstOrDefault(x => x.Id == item.Id);
            await _context.Entry(user).ReloadAsync();
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


