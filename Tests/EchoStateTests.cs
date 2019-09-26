using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using Tests.Mock;
using Tests.States;

namespace Tests
{
    internal class EchoStateTests : BaseTest
    {
        private BotHandler<ChatActivity> botHandler;
        private MockConnector<ChatActivity> connector;

        [SetUp]
        public void Configure()
        {
            services.AddScoped(typeof(ChatState<>), typeof(EchoState<>));

            var provider = services.BuildServiceProvider();

            botHandler = provider.GetRequiredService<BotHandler<ChatActivity>>();
            connector = provider.GetRequiredService<IConnector<ChatActivity>>() as MockConnector<ChatActivity>;

        }


        [Test]
        public async Task Handle()
        {
            var message = new TextActivity
            {
                Chat = new Chat { Id = "26"},
                Text = "test",
            };

            await botHandler.Handle(message);

            await botHandler.Handle(message);

            Assert.IsTrue(connector.Messages.Count == 2);
            Assert.IsTrue(connector.Messages.Cast<TextActivity>().Count(s => s.Text == message.Text) == 2);
        }
    }
}
