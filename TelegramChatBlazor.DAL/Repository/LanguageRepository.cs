using AutoMapper;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models.Languages;

namespace TelegramChatBlazor.DAL.Repository
{
    public class LanguageRepository: ILanguageRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public LanguageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Language> GetAll()
        {
            var languages = _context.Languages.ToList();
            return _mapper.Map<List<Language>>(languages);
        }

        public void Create(Language item)
        {
            var language = _mapper.Map<Entities.Language>(item);
            _context.Languages.Add(language);
        }

        public void Delete(long id)
        {
            var language = _context.Languages.Find(id);
            if (language != null)
                _context.Languages.Remove(language);
        }

        public Language GetById(long Id)
        {
            var manager = _context.Managers.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<Language>(manager);
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

