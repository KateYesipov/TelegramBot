using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IColorService
    {
        public List<Color> GetColors();
    }
}
