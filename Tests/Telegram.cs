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
