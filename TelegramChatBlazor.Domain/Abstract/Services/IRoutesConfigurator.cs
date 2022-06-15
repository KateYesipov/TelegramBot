using Microsoft.AspNetCore.Routing;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IRoutesConfigurator
    {
        void BuildRoutesUsingTelegramChatBlazors(IEndpointRouteBuilder builder);
    }
}
