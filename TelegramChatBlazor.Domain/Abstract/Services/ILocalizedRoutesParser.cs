using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChatBlazor.Domain.Models.Routing.LocalizedRoute;

namespace TelegramChatBlazor.Domain.Abstract.Services
{
    public interface ILocalizedRoutesParser
    {
        LocalizedRulesRoot ParseTelegramChatBlazors();
    }
}
