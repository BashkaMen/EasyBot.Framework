using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public abstract class IChatState
    {
        public string Type => GetType().FullName;
        public abstract Task<IChatState> HandleActivity(ChatActivity activity, ChatContext context);
    }
}
