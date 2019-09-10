using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public sealed class ChatContext
    {
        public string ChatId { get; }
        public string ChannelName { get; }

        public ChatContext()
        {
            
        }


        public async Task<string> Send(ChatActivity activity)
        {
            return "";
        }

        public async Task Edit(string activityId, ChatActivity activity)
        {

        }

    }
}
