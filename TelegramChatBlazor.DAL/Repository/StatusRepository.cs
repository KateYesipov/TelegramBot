using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.DAL.Repository
{
    public class StatusRepository : IStatusRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public StatusRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Status> GetAll()
        {
            var userStatus = _context.UserStatus.ToList();
            return _mapper.Map<List<Status>>(userStatus);
        }

        public List<UserStatus> GetIncludeUserAll()
        {
            var userStatus = _context.Users.Include(x=>x.UserStatus).ToList().GroupBy(y => y.UserStatus.Name).Select(u=>new UserStatus { NameStatus=u.Key,Users= _mapper.Map<List<User>>(u.ToList())}).ToList();
            return userStatus;
        }

        public void Create(Status item)
        {
            var userStatus = _mapper.Map<Entities.UserStatus>(item);
            _context.UserStatus.Add(userStatus);
        }

        public void Delete(long id)
        {
            var userStatus = _context.UserStatus.Find(id);
            if (userStatus != null)
                _context.UserStatus.Remove(userStatus);
        }

        public Status GetById(long Id)
        {
            var userStatus = _context.UserStatus.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<Status>(userStatus);
        }

        public void Update(Status item)
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


