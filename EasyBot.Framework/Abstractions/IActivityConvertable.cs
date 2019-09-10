using EasyBot.Framework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public interface IActivityExtrable
    {
        Task<IEnumerable<ChatActivity>> Extract();
    }
}
