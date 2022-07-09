using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.DAL.Repository
{
    public class CategoryAnswerRepository: ICategoryAnswerRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public CategoryAnswerRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Category> GetAll()
        {
            var category = _context.Categories.ToList();
            return _mapper.Map<List<Category>>(category);
        }

        public void Create(Category item)
        {
            var category = _mapper.Map<Entities.Category>(item);
            _context.Categories.Add(category);
        }

        public void Delete(long id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
                _context.Categories.Remove(category);
        }

        public Category GetById(long Id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<Category>(category);
        }

        public void Update(Category item)
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

