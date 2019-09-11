using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal class TestMessageConverter : IConverter<TestMessage>
    {
        public async Task<ChatActivity> Convert(TestMessage model)
        {
            await Task.CompletedTask;
            return new TextActivity(model.text, model.chatId.ToString());
        }

        public async Task<IEnumerable<TestMessage>> ConvertBack(ChatActivity model)
        {
            await Task.CompletedTask;

            return new[] { new TestMessage
            {
                chatId = int.Parse(model.ChatId),
                text = (model as TextActivity).Text
            }};
        }
    }
}
