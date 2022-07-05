using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.HelpWord;

public class Category 
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<Answer> Answers { get; set; }
    public Category()
    {
        Answers = new List<Answer>();
    }
}
