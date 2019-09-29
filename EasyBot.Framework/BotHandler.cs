using EasyBot.Framework.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class BotHandler<TModel>
    {
        private readonly IConverter<TModel> converter;
        private readonly ChatContext<TModel> context;
        private readonly IChatStateStorage<TModel> storage;
        private readonly ChatState<TModel> chatState;

        public BotHandler(IConverter<TModel> converter, ChatContext<TModel> context, IChatStateStorage<TModel> storage, ChatState<TModel> chatState)
        {
            this.converter = converter;
            this.context = context;
            this.storage = storage;
            this.chatState = chatState;
        }

        public async Task Handle(TModel model)
        {
            var activity = await converter.Convert(model);
            var key = activity.Chat.Id;

            var state = await storage.GetValue(key) ?? chatState;
            var newState = await state.HandleActivity(activity, context);

            await storage.SaveChanges(key, newState);
        }
    }
}
