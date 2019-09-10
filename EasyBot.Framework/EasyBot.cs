using EasyBot.Framework.Abstractions;
using System.Threading.Tasks;

namespace EasyBot.Framework
{
    public class EasyBot
    {
        public EasyBot()
        {

        }

        public async Task Handle<T>(T activity) where T : IActivityExtrable
        {
            foreach (var item in await activity.Extract())
            {

            }
        }
    }
}
