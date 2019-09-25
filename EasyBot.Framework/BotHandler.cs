using EasyBot.Framework.Abstractions;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class BotHandler<TModel, TChannel> where TChannel : IChannel
    {
        private readonly IConverter<TModel> converter;
        private readonly ChatContext<TChannel> context;
        private readonly IChatStateStorage<TChannel> storage;

        public BotHandler(IConverter<TModel> converter, ChatContext<TChannel> context, IChatStateStorage<TChannel> storage)
        {
            this.converter = converter;
            this.context = context;
            this.storage = storage;
        }

        public async Task Handle(TModel model)
        {
            var activity = await converter.Convert(model);
            var key = activity.ChatId;

            var state = await storage.GetValue(key);
            var newState = await state.HandleActivity(activity, context);

            await storage.SaveChanges(key, newState);
        }
    }
}
