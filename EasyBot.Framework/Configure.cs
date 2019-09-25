using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Channels;
using EasyBot.Framework.Connectors;
using EasyBot.Framework.Converters;
using EasyBot.Framework.Models.Telegram;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Reflection;

namespace EasyBot.Framework
{
    public static class Configure
    {
        public static void AddEasyBotFramework(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMemoryCache();
            services.AddScoped(typeof(ChatContext<>));
            services.AddScoped(typeof(BotHandler<,>));

            services.AddTelegramCore();
        }

        public static void AddTelegramCore(this IServiceCollection services)
        {
            services.AddScoped<IChatStateStorage<TelegramChannel>, MemoryChatStateStorage<TelegramChannel>>();
            services.AddScoped<IConnector<TelegramChannel>, TelegramConnector>();
            services.AddScoped<IConverter<TelegramActivity>, TelegramConverter>();
        }
    }
}
