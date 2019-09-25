using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Connectors;
using EasyBot.Framework.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EasyBot.Framework.Channels
{

    public class TelegramConnector : IConnector<TelegramChannel>
    {
        public async Task<string> SendActivity(ChatActivity activity)
        {
            Debug.WriteLine($"Sended: {JsonConvert.SerializeObject(activity)}");

            return Guid.NewGuid().ToString();
        }
    }

}
