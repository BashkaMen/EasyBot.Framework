using EasyBot.Framework.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class BotHandler<TModel, TChannel> where TChannel : IChannel
    {
        private readonly IConverter<TModel> converter;
        private readonly ChatContext<TChannel> context;
        private readonly IChatStateStorage<TChannel> storage;
        private readonly IEnumerable<IChatState<TChannel>> chatStates;

        public BotHandler(IConverter<TModel> converter, ChatContext<TChannel> context, IChatStateStorage<TChannel> storage, IEnumerable<IChatState<TChannel>> chatStates)
        {
            this.converter = converter;
            this.context = context;
            this.storage = storage;
            this.chatStates = chatStates;

            if (!chatStates.Any()) throw new ArgumentException("Resolved chat states count: 0, register chat state");
        }

        public async Task Handle(TModel model)
        {
            var activity = await converter.Convert(model);
            var key = activity.Chat.Id;

            var state = await storage.GetValue(key) ?? chatStates.First();
            var newState = await state.HandleActivity(activity, context);

            await storage.SaveChanges(key, newState);
        }
    }
}
