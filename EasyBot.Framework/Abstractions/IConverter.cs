using EasyBot.Framework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public interface IConverter<T>
    {
        Task<ChatActivity> Convert(T model);
        Task<IEnumerable<T>> ConvertBack(ChatActivity model);
    }
}
