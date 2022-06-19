using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.SignalR
{
    public class MessageNotification
    {
        public string? PartnerAvatar { get; set; }
        public string? PartnerUserName { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerLastName { get; set; }
        public Message Message { get; set; }
    }
}
