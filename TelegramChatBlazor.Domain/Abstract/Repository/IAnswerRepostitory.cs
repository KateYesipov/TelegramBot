using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IAnswerRepostitory
    {
        Answer GetById(long id);
        List<Answer> GetAll();
        void Create(Answer item);
        void Delete(long id);
        void Save();
    }
}
