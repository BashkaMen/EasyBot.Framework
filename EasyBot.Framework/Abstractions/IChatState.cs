using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public abstract class IChatState<T> where T : IChannel
    {
        public string Type => GetType().FullName;
        public abstract Task<IChatState<T>> HandleActivity(ChatActivity activity, ChatContext<T> context);
    }
}
