﻿using AutoMapper;
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

        public List<Answer> GetByCategoryId(long categoryId)
        {
            var answer = _context.Answers.Where(x => x.CategoryId == categoryId);
            return _mapper.Map<List<Answer>>(answer);
        }
        public void Update(Answer item)
        {
            _context.Database.ExecuteSqlRaw(@"UPDATE Answers SET  
            ShortName={1}, FullAnswer={2},CreatedAt={3},CategoryId={4}
            WHERE Id={0}",
           item.Id, item.ShortName, item.FullAnswer,item.CreatedAt,item.CategoryId);
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


