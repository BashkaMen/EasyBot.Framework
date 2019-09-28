namespace EasyBot.Framework.Models
{
    public abstract class ChatActivity
    {
        public Chat Chat { get; set; }

        public TextActivity CreateActivity(string text)
        {
            return new TextActivity
            {
                Chat = Chat,
                Text = text
            };
        }
    }

    public class TextActivity : ChatActivity
    {
        public string Text { get; set; }
    }
}
