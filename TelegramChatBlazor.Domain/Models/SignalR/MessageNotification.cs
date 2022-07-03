using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Models.SignalR
{
    public class MessageNotification
    {
        public string? PartnerAvatar { get; set; }
        public string? PartnerUserName { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerLastName { get; set; }
        public string Token { get; set; }
        public Message Message { get; set; }
    }
}
