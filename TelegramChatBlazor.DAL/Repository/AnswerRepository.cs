using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.DAL.Repository
{
    public class AnswerRepository: IAnswerRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public AnswerRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Answer> GetAll()
        {
            var answers = _context.Answers.ToList();
            return _mapper.Map<List<Answer>>(answers);
        }

        public void Create(Answer item)
        {
            var answer = _mapper.Map<Entities.Answer>(item);
            _context.Answers.Add(answer);
        }

        public void Delete(long id)
        {
            var answer = _context.Answers.Find(id);
            if (answer != null)
                _context.Answers.Remove(answer);
        }

        public Answer GetById(long Id)
        {
            var answer = _context.Answers.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<Answer>(answer);
        }

        public void Update(Answer item)
        {
            _context.Update(item);
            _context.Entry(item).State = EntityState.Modified;
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


