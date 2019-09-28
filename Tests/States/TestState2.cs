﻿using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Tests.States
{
    public class TestState2<TModel> : ChatState<TModel>
    {
        private readonly IServiceProvider provider;

        public TestState2(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public override async Task<ChatState<TModel>> HandleActivity(ChatActivity activity, ChatContext<TModel> context)
        {
            var textMessage = activity.CreateActivity(GetType().Name);

            await context.Send(textMessage);
            return provider.GetRequiredService<TestState3<TModel>>();
        }
    }
}


