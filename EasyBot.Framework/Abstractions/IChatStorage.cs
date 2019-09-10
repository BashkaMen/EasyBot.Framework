using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public interface IChatStorage
    {
        Task<T> GetValue<T>(string key);
        Task SaveChanges<T>(string key, T value);
    }
}
