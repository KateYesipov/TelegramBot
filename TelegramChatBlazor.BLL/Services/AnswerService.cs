using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.HelpWord;

namespace TelegramChatBlazor.BLL.Services
{
    public class AnswerService: IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public void Create(Answer item)
        {
            if (item != null)
            {
                item.CreatedAt = DateTime.Now;
                _answerRepository.Create(item);
                _answerRepository.Save();
            }
        }

        public void DeleteById(long id)
        {
            _answerRepository.Delete(id);
            _answerRepository.Save();
        }

        public List<Answer> GetAll()
        {
            return _answerRepository.GetAll();
        }

        public Answer GetById(long Id)
        {
            return _answerRepository.GetById(Id);
        }


        public void Update(Answer item)
        {
            _answerRepository.Update(item);
            _answerRepository.Save();
        }
    }
}



    }
}
