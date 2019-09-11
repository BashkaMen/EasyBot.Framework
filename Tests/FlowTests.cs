using EasyBot.Framework;
using System.Threading.Tasks;

namespace Tests
{
    internal class FlowTests
    {
        public async Task Handle()
        {
            var message = new TestMessage
            {
                chatId = 100,
                text = "qweqweqwe",
                fromUser = "asdgfasd asdjkas dasdas"
            };


            await new BotProcessor(null).Handle(message);


        }
    }
}
