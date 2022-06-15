using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.DAL.Entities
{
    public class Message : Entity<long>
    {
        public Message(long chatId, string text, string avatat, string userName, string firsiName, bool isSender)
        {
            ChatId = chatId;
            Text = text;
            Avatat = avatat;
            UserName = userName;
            FirsiName = firsiName;
            IsSender = isSender;
        }

        public long ChatId { get; set; }
        public string Text { get; set; }
        public string Avatat { get; set; }
        public string UserName { get; set; }
        public string FirsiName { get; set; }
        public bool IsSender { get; set; }
    }
}
