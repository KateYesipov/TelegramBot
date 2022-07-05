using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.DAL.Entities
{
    public class Answer : Entity<long>
    {
        public string ShortName { get; set; }
        public string FullAnswer { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
