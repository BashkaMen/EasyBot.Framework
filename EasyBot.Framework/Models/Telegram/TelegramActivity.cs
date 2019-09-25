using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBot.Framework.Models.Telegram
{
    public class TelegramActivity
    {
        public string Text { get; set; }
        public Chat Chat { get; set; }
    }

    public class Chat
    {
        public string Id { get; set; }
    }
}
