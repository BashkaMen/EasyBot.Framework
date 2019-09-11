using EasyBot.Framework.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class BotProcessor
    {
        private readonly IServiceProvider provider;

        public BotProcessor(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public async Task Handle<TModel, TChannel>(TModel model) where TChannel : IChannel
        {
            var converter = provider.GetRequiredService<IConverter<TModel>>();
            var connector = provider.GetRequiredService<IConnector<TChannel>>();

            var activity = await converter.Convert(model);

            var context = new ChatContext<TChannel>(connector);


            var state = provider.GetRequiredService<IChatState<IChannel>>();


            await state.HandleActivity(activity, context);
        }
    }
}
