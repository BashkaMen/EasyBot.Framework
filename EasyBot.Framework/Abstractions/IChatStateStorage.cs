using EasyBot.Framework.Models;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public interface IChatStateStorage<TModel>
    {
        Task<ChatState<TModel>> GetValue(string key);
        Task SaveChanges(string key, ChatState<TModel> value);
    }
}
