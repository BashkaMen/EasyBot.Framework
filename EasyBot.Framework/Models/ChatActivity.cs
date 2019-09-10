using EasyBot.Framework.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBot.Framework.Models
{
    public abstract class ChatActivity
    {
    }

    public class TextActivity : ChatActivity
    {
        public string Text { get; }

        public TextActivity(string text)
        {
            Text = text;
        }
    }
}
