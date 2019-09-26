using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace Tests.States
{
    public class EchoState<TModel> : ChatState<TModel>
    {
        public override async Task<ChatState<TModel>> HandleActivity(ChatActivity activity, ChatContext<TModel> context)
        {
            await context.Send(activity);

            return this;
        }
    }
}


