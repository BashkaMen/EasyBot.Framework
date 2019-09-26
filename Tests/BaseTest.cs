using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using Tests.Mock;
using Tests.States;

namespace Tests
{
    class BaseTest
    {
        protected ServiceCollection services;

        [SetUp]
        public void Setup()
        {
            services = new ServiceCollection();

            services.AddEasyBotFramework();

            services.AddScoped<IConverter<ChatActivity>, MockConverter>();
            services.AddScoped(typeof(IConnector<>), typeof(MockConnector<>));            
        }
    }
}
