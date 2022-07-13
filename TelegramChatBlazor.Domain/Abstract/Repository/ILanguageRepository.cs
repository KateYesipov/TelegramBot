using TelegramChatBlazor.Domain.Models.Languages;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface ILanguageRepository
    {
        Language GetById(long id);
        List<Language> GetAll();
        void Create(Language item);
        void Delete(long id);
        void Save();
    }
}
