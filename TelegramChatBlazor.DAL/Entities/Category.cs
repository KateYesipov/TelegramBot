﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.DAL.Entities
{
    public class Category : Entity<long>
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Answer> Answers { get; set; }
        public Category()
        {
            Answers = new List<Answer>();
        }
    }
}
