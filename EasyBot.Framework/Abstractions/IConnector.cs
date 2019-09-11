using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EasyBot.Framework.Models;

namespace EasyBot.Framework.Abstractions
{
    public interface IConnector<T> where T : IChannel
    {
        Task<string> SendActivity(ChatActivity activity);
    }
}
