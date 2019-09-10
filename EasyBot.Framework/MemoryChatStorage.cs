using EasyBot.Framework.Abstractions;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class MemoryChatStorage : IChatStorage
    {
        private readonly IMemoryCache cache;

        public MemoryChatStorage(IMemoryCache cache)
        {
            this.cache = cache;
        }

        public Task<T> GetValue<T>(string key)
        {
            return Task.FromResult(cache.Get<T>(key));
        }

        public Task SaveChanges<T>(string key, T value)
        {
            cache.Set(key, value);

            return Task.CompletedTask;
        }
    }
}
