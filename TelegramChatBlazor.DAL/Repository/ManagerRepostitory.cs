using AutoMapper;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models.Managers;

namespace TelegramChatBlazor.DAL.Repository
{
    public class ManagerRepostitory : IManagerRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public ManagerRepostitory(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Manager> GetAll()
        {
            var managers = _context.Managers.ToList();
            return _mapper.Map<List<Manager>>(managers);
        }

        public void Create(Manager item)
        {
            var manager = _mapper.Map<Entities.Manager>(item);
            _context.Managers.Add(manager);
        }

        public void Delete(long id)
        {
            var manager = _context.Managers.Find(id);
            if (manager != null)
                _context.Managers.Remove(manager);
        }

        public Manager GetById(long Id)
        {
            var manager = _context.Managers.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<Manager>(manager);
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

