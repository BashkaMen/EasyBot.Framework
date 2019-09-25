using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Connectors;
using EasyBot.Framework.Models.Telegram;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests
{
    internal class Telegram
    {
        private BotHandler<TelegramActivity, TelegramChannel> botHandler;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();

            services.AddEasyBotFramework();
            services.AddTelegramCore();

            services.AddScoped<IChatState<TelegramChannel>, EchoState<TelegramChannel>>();

            //services.AddScoped<IChatState<TelegramChannel>, TestState1<TelegramChannel>>();
            //services.AddScoped<TestState1<TelegramChannel>>();

            //services.AddScoped<IChatState<TelegramChannel>, TestState2<TelegramChannel>>();
            //services.AddScoped<TestState2<TelegramChannel>>();

            //services.AddScoped<IChatState<TelegramChannel>, CounterState<TelegramChannel>>();


            var provider = services.BuildServiceProvider();


            botHandler = provider.GetRequiredService<BotHandler<TelegramActivity, TelegramChannel>>();
        }

        [Test]
        public async Task Handle()
        {
            var message = new TelegramActivity
            {
                Chat = new Chat
                {
                    Id ="26"
                },
                Text = "test"
            };

            await botHandler.Handle(message);
            await botHandler.Handle(message);
        }
    }
}
