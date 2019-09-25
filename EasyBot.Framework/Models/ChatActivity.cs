namespace EasyBot.Framework.Models
{
    public abstract class ChatActivity
    {
        public Chat Chat { get; set; }
    }

    public class TextActivity : ChatActivity
    {
        public string Text { get; set; }
    }
}
