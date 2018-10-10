using System.Threading;
using System.Threading.Tasks;

namespace Cow.io.PushNotification
{
    public interface IPushNotificationDispatcher
    {
        Task<IPushNotificationResponse> Dispatch(IPushNotification notification, CancellationToken cancellation = default(CancellationToken));
    }
}
