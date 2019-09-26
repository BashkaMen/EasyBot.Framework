using EasyBot.Framework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public interface IConverter<TModel>
    {
        Task<ChatActivity> Convert(TModel model);
        Task<TModel> ConvertBack(ChatActivity model);
    }
}
