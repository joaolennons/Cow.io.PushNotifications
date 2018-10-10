using System.Collections.Generic;

namespace Cow.io.PushNotification
{
    public interface IPushNotificationResponse
    {
        Response Status { get; }
        List<string> Errors { get; }
    }
}
