using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IAnswerService
    {
        Answer GetById(long Id);
        List<Answer> GetByCategoryId(long categoryId);
        List<Answer> GetAll();
        void Update(Answer item);
        void Create(Answer item);
        void DeleteById(long id);
    }
}
