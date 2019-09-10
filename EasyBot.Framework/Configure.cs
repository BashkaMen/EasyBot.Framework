using EasyBot.Framework.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace EasyBot.Framework
{
    public static class Configure
    {
        public static void AddEasyBotFramework(this IServiceCollection services)
        {
            //services.AddScoped(typeof(ChatContext<>));
        }
    }
}
