using TelegramChatBlazor.Domain.Models.Languages;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface ILanguageService
    {
        Language GetById(long Id);
        List<Language> GetAll();
        void Create(Language item);
        void DeleteById(long id);
    }
}
