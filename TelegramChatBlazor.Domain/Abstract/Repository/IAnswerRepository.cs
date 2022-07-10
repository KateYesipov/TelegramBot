using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IAnswerRepository
    {
        Answer GetById(long id);
        List<Answer> GetByCategoryId(long id);      
        List<Answer> GetAll();
        void Create(Answer item);
        void Update(Answer item);
        void Delete(long id);
        void Save();
    }
}
