using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.DAL.Entities
{
    public class Manager : Entity<long>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ImgPath { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime LastOnline { get; set; }
    }
}
