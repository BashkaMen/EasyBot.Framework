using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Connectors;
using EasyBot.Framework.Models;
using System;
using System.Threading.Tasks;

namespace EasyBot.Framework.Channels
{

    public class TelegramConnector : IConnector<TelegramChannel>
    {
        public Task<string> SendActivity(ChatActivity activity)
        {
            throw new NotImplementedException();
        }
    }

}
