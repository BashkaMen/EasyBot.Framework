using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public sealed class ChatContext<T> where T : IChannel
    {
        private readonly IConnector<T> connector;




        public ChatContext(IConnector<T> connector)
        {
            this.connector = connector;
        }


        public async Task<string> Send(ChatActivity activity)
        {
            var id = await connector.SendActivity(activity);
            return id;
        }

    }
}
