﻿using AutoMapper;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.DAL.Repository
{
    public class AttachmentRepository : IAttachmentRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public AttachmentRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Attachment> GetAll()
        {
            var attachment = _context.Managers.ToList();
            return _mapper.Map<List<Attachment>>(attachment);
        }

        public void Create(Attachment item)
        {
            var attachment = _mapper.Map<Entities.Attachment>(item);
            _context.Attachments.Add(attachment);
        }

        public void Delete(long id)
        {
            var attachment = _context.Managers.Find(id);
            if (attachment != null)
                _context.Managers.Remove(attachment);
        }

        public Attachment GetById(long Id)
        {
            var attachment = _context.Managers.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<Attachment>(attachment);
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

