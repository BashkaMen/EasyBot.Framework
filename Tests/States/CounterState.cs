using EasyBot.Framework;
using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace Tests.States
{
    public class CounterState<TModel> : ChatState<TModel>
    {
        public int Counter { get; set; }

        public override async Task<ChatState<TModel>> HandleActivity(ChatActivity activity, ChatContext<TModel> context)
        {
            await context.Send(new TextActivity
            {
                Chat = activity.Chat,
                Text = $"Count: {Counter++}"
            });

            return this;
        }
    }
}


