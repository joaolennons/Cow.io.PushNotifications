namespace Cow.io.PushNotification
{
    public class PushNotification : IPushNotification
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Receiver { get; set; }
        public object Data { get; set; }
    }
}
