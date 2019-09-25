using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public interface IChatStateStorage<T> where T : IChannel
    {
        Task<IChatState<T>> GetValue(string key);
        Task SaveChanges(string key, IChatState<T> value);
    }
}
