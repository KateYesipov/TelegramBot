

using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Repository
{
    public interface IColorRepository
    {
        List<Color> GetAll();
    }
}
