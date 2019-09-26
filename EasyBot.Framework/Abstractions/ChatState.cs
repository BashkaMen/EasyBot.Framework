using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public abstract class ChatState<TModel>
    {
        public abstract Task<ChatState<TModel>> HandleActivity(ChatActivity activity, ChatContext<TModel> context);
    }
}
