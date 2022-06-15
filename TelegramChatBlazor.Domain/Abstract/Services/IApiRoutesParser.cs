using TelegramChatBlazor.Domain.Models.Routing;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IApiRoutesParser
    {
        List<RoutesSet> ParseTelegramChatBlazors();
    }
}
