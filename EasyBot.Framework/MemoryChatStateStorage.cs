using EasyBot.Framework.Abstractions;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class MemoryChatStateStorage<TModel> : IChatStateStorage<TModel>
    {
        private readonly IMemoryCache cache;

        public MemoryChatStateStorage(IMemoryCache cache)
        {
            this.cache = cache;
        }

        public Task<ChatState<TModel>> GetValue(string key)
        {
            return Task.FromResult(cache.Get<ChatState<TModel>>(key));
        }

        public Task SaveChanges(string key, ChatState<TModel> value)
        {
            cache.Set(key, value);

            return Task.CompletedTask;
        }
    }
}
