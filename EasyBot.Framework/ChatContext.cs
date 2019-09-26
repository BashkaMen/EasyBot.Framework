using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public sealed class ChatContext<TModel>
    {
        private readonly IConnector<TModel> connector;
        private readonly IConverter<TModel> converter;

        public ChatContext(IConnector<TModel> connector, IConverter<TModel> converter)
        {
            this.connector = connector;
            this.converter = converter;
        }


        public async Task<string> Send(ChatActivity activity)
        {
            var converted = await converter.ConvertBack(activity);

            var id = await connector.SendActivity(converted);
            return id;
        }

    }
}
