using System.Threading.Tasks;

namespace EasyBot.Framework.Abstractions
{
    public interface IConnector<TModel>
    {
        Task<string> SendActivity(TModel activity);
    }
}
