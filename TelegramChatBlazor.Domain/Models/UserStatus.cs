using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models
{
    public class UserStatus
    {
        public string NameStatus { get; set; }
        public List<User> Users { get; set; }
    }
}
