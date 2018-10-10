namespace Cow.io.PushNotification
{
    public interface IPushNotification
    {
        string Title { get; }
        string Text { get; }
        string Receiver { get; }
    }
}
