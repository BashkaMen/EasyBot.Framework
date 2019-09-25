using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
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
}
