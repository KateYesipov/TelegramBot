using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Languages;

namespace TelegramChatBlazor.BLL.Services
{
    public class LanguageService: ILanguageService
    {

        private readonly ILanguageRepository _languageRepository;

        public LanguageService(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public void Create(Language item)
        {
            if (item != null)
            {
                _languageRepository.Create(item);
                _languageRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _languageRepository.Delete(id);
            _languageRepository.Save();
        }

        public List<Language> GetAll()
        {
            return _languageRepository.GetAll();
        }

        public Language GetById(long Id)
        {
            return _languageRepository.GetById(Id);
        }
    }
}


