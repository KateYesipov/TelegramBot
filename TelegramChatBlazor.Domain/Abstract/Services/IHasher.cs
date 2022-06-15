using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface IHasher
    {
        string GetHash(string str);
        bool Сompare(string hash, string str);
    }
}
