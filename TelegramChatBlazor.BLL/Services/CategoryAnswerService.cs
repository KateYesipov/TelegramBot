using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.BLL.Services
{
    public class CategoryAnswerService : ICategoryAnswerService
    {
        private readonly ICategoryAnswerRepository _categoryAnswerRepository;
        public CategoryAnswerService(ICategoryAnswerRepository categoryAnswerRepository)
        {
            _categoryAnswerRepository = categoryAnswerRepository;
        }

        public void Create(Category item)
        {
            if (item != null)
            {
                item.CreatedAt = DateTime.Now;
                _categoryAnswerRepository.Create(item);
                _categoryAnswerRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _categoryAnswerRepository.Delete(id);
            _categoryAnswerRepository.Save();
        }

        public List<Category> GetAll()
        {
            return _categoryAnswerRepository.GetAll();
        }

        public Category GetById(long Id)
        {
            return _categoryAnswerRepository.GetById(Id);
        }


        public void Update(Category item)
        {
            _categoryAnswerRepository.Update(item);
            _categoryAnswerRepository.Save();
        }
    }
}


