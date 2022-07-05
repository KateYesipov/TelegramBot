using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Models.Managers;

public class Manager
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string ImgPath { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime LastOnline { get; set; }
}
