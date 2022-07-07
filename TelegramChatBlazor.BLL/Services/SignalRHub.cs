using Microsoft.AspNetCore.SignalR;
using TelegramChatBlazor.Domain.Models.SignalR;

namespace TelegramChatBlazor.BLL.Services
{
    public class SignalRHub : Hub
    {
        public async Task SendMessageAsync(ChatNotification message)
        {
            await Clients.All.SendAsync("Send", message);
        }
    }
}