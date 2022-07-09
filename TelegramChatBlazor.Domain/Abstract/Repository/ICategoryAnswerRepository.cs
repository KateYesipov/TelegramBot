using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface ICategoryAnswerRepository
    {
        Category GetById(long id);
        List<Category> GetAll();
        void Create(Category item);
        void Update(Category item);
        void Delete(long id);
        void Save();
    }
}
