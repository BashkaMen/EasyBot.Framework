using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Tests
{
    public class EchoState<T> : IChatState<T> where T : IChannel
    {
        public override async Task<IChatState<T>> HandleActivity(ChatActivity activity, ChatContext<T> context)
        {
            await context.Send(activity);

            return this;
        }
    }

    public class CounterState<T> : IChatState<T> where T : IChannel
    {
        public int Counter { get; set; }

        public override async Task<IChatState<T>> HandleActivity(ChatActivity activity, ChatContext<T> context)
        {
            await context.Send(new TextActivity
            {
                Chat = activity.Chat,
                Text = $"Count: {Counter++}"
            });

            return this;
        }
    }

    public class TestState1<T> : IChatState<T> where T : IChannel
    {
        private readonly IServiceProvider provider;

        public TestState1(IServiceProvider provider)
        {
            this.provider = provider;
        }


        public override async Task<IChatState<T>> HandleActivity(ChatActivity activity, ChatContext<T> context)
        {
            return provider.GetRequiredService<TestState2<T>>();
        }
    }

    public class TestState2<T> : IChatState<T> where T : IChannel
    {
        private readonly IServiceProvider provider;

        public TestState2(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public override async Task<IChatState<T>> HandleActivity(ChatActivity activity, ChatContext<T> context)
        {
            return provider.GetRequiredService<TestState1<T>>();
        }
    }
}
