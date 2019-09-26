using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models.Telegram;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EasyBot.Framework.Channels
{

    public class TelegramConnector : IConnector<TelegramActivity>
    {
        public async Task<string> SendActivity(TelegramActivity activity)
        {
            Debug.WriteLine($"Sended: {JsonConvert.SerializeObject(activity)}");

            return Guid.NewGuid().ToString();
        }
    }

}
