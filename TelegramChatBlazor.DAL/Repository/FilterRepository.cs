using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models.Filters;

namespace TelegramChatBlazor.DAL.Repository
{
    public class FilterRepository : IFilterRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public FilterRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Filter> GetAll()
        {
            var filters = _context.Filters.ToList();
            return _mapper.Map<List<Filter>>(filters);
        }

        public void Create(Filter item)
        {
            var filter = _mapper.Map<Entities.Filter>(item);
            _context.Filters.Add(filter);
        }

        public void Delete(long id)
        {
            var filter = _context.Filters.Find(id);
            if (filter != null)
                _context.Filters.Remove(filter);
        }

        public Filter GetById(long Id)
        {
            var filter = _context.Filters.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<Filter>(filter);
        }

        public void Update(Filter item)
        {
            _context.Database.ExecuteSqlRaw(@"UPDATE Filters SET  
            ColorHex={1}, Readed={2},Archived={3},Mailing={4},Created_at={5}
            WHERE Id={0}",
            item.Id, item.ColorHex, item.Readed, item.Archived, item.Mailing, item.Created_at);
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


