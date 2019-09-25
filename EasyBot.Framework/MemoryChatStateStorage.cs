using EasyBot.Framework.Abstractions;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class MemoryChatStateStorage<T> : IChatStateStorage<T> where T : IChannel
    {
        private readonly IMemoryCache cache;

        public MemoryChatStateStorage(IMemoryCache cache)
        {
            this.cache = cache;
        }

        public Task<IChatState<T>> GetValue(string key)
        {
            return Task.FromResult(cache.Get<IChatState<T>>(key));
        }

        public Task SaveChanges(string key, IChatState<T> value)
        {
            cache.Set(key, value);

            return Task.CompletedTask;
        }
    }
}
