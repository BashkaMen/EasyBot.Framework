using EasyBot.Framework.Abstractions;
using EasyBot.Framework.Models.Telegram;
using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyBot.Framework.Connectors
{

    public class TelegramConnector : IConnector<TelegramActivity>
    {
        private readonly HttpClient http;
        private readonly string baseUrl;

        public TelegramConnector(TelegramToken token)
        {
            http = new HttpClient();
            baseUrl = $"https://api.telegram.org/bot{token.Value}";
        }


        public async Task SendActivity(TelegramActivity activity)
        {
            var query = new QueryBuilder();
            query.Add("chat_id", activity.Chat.Id.ToString());
            query.Add("text", activity.Text);

            var req = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/sendMessage{query.ToQueryString()}");
            var response = await http.SendAsync(req);

            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();
        }
    }

}
