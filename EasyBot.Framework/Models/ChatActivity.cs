namespace EasyBot.Framework.Models
{
    public abstract class ChatActivity
    {
        public abstract string Type { get; }
        public string ChatId { get; set; }

    }

    public class TextActivity : ChatActivity
    {
        public override string Type => "text";
        public string Text { get; }
    }
}
