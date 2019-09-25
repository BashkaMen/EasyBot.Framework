using AutoMapper;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using EasyBot.Framework.Models.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBot.Framework.Converters
{
    public class TelegramConverter : IConverter<TelegramActivity>
    {
        private readonly IMapper mapper;

        public TelegramConverter(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<ChatActivity> Convert(TelegramActivity model)
        { 
            if (!string.IsNullOrEmpty(model.Text))
            {
                return mapper.Map<TextActivity>(model);
            }

            throw new NotSupportedException("Не поддерживается конвертирование");
        }

        public async Task<IEnumerable<TelegramActivity>> ConvertBack(ChatActivity model)
        {
            var result = new List<TelegramActivity>();

            if (model is TextActivity textMessage)
            {
                result.Add(mapper.Map<TelegramActivity>(textMessage));
            }

            if (result.Any()) return result;

            throw new NotSupportedException("Не поддерживается конвертирование");
        }
    }
}
