using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Models.SignalR
{
    public class ChatNotification
    {
        public long ChatId { get; set; }
        public string? PartnerAvatar { get; set; }
        public string? PartnerUserName { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerLastName { get; set; }
        public string Token { get; set; }
        public MessageNotification Message { get; set; }
    }
}
