using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using System;
using System.Threading.Tasks;

namespace EasyBot.Framework.Connectors
{
    public class TelegramChannel : IChannel
    {
        public string Name => "Telegram";
    }

    public class TelegramConnector : IConnector<TelegramChannel>
    {
        public Task<string> SendActivity(ChatActivity activity)
        {
            throw new NotImplementedException();
        }
    }

}
