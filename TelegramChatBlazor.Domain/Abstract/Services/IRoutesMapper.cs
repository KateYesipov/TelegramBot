using Microsoft.AspNetCore.Routing;
using TelegramChatBlazor.Domain.Models.Routing;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IRoutesMapper
    {
        void MapRoutes(List<RoutesSet> routesCollection, IEndpointRouteBuilder builder);
    }
}
