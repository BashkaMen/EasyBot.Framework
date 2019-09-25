using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using EasyBot.Framework.Models.Telegram;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyBot.Framework.Converters
{
    public class TelegramConverter : IConverter<TelegramActivity>
    {
        public Task<ChatActivity> Convert(TelegramActivity model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TelegramActivity>> ConvertBack(ChatActivity model)
        {
            throw new NotImplementedException();
        }
    }
}
