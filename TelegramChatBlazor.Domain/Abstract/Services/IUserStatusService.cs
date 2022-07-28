using TelegramChatBlazor.Domain.Models;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IUserStatusService
    {
        List<UserStatus> GetAll();
    }
}
