using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models.Messages;

namespace TelegramChatBlazor.Domain.Models.Chats
{
    public class SelectChat
    {
        public long Id { get; set; }
        public long TelegramChatId { get; set; }
        public string? PartnerAvatar { get; set; }
        public string? ColorAvatar { get; set; }
        public string? PartnerUserName { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerLastName { get; set; }
        public string BotUserName { get; set; }
        public string? BotAvatar { get; set; }
        public long BotId { get; set; }
        public Message LastMessage { get; set; }
    }
}
