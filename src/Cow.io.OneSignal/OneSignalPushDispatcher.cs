using Cow.io.PushNotification;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cow.io.OneSignal
{
    internal class OneSignalPushDispatcher : IPushNotificationDispatcher
    {
        public Task<IPushNotificationResponse> Dispatch(IPushNotification notification, CancellationToken cancellation = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
