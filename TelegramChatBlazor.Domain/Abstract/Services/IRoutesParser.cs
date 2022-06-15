using TelegramChatBlazor.Domain.Models.Routing;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IRoutesParser
    {
        List<RoutesSet> ParseTelegramChatBlazors();
    }
}
