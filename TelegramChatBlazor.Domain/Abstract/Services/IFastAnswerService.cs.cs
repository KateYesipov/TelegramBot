using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface ICategoryAnswerService
    {
        Category GetById(long Id);
        List<Category> GetAll();
        void Update(Category item);
        void Create(Category item);
        void DeleteById(long id);
    }
}
