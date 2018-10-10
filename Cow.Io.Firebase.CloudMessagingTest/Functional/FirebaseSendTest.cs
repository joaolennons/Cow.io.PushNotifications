using Cow.io.Firebase.CloudMessaging;
using Cow.io.Firebase.CloudMessaging.Configuration;
using Cow.io.PushNotification;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Cow.Io.Firebase.CloudMessagingTest
{
    public class FirebaseSendTest
    {
        [Fact]
        public async Task SendMessage_Should_Send_Successfully()
        {
            var configuration = new FirebaseApiConfiguration
            {
                SendUrl = "https://fcm.googleapis.com/fcm/send",
                Token = "={your-firebase-api-token-here}"
            };

            IPushNotificationDispatcher dispatcher = new FirebasePushDispatcher(new HttpClient(), configuration);
            var notification = new PushNotification
            {
                Title = "Título",
                Text = $"Push Notification from {nameof(FirebaseSendTest)}",
                Receiver = "${your-device-token-here}"
            };

            var response = await dispatcher.Dispatch(notification);
            Assert.True(response.Status == Response.Success);
            Assert.False(response.Errors.Any());
        }
    }
}
