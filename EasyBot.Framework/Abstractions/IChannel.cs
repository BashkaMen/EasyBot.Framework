namespace EasyBot.Framework.Abstractions
{
    public interface IChannel
    {
        /// <summary>
        /// Unique channel name
        /// Example: Telegram, Viber, FB, Skype ...
        /// </summary>
        public string Name { get; }
    }
}
