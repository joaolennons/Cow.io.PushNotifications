using Cow.io.Firebase.CloudMessaging;
using Cow.io.Firebase.CloudMessaging.Configuration;
using Cow.io.PushNotification;
using System;
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
                Token = "=AIzaSyCo4Rc5caZqb-wEAK0pYYweyGMMwejk3uQ",
            };

            IPushNotificationDispatcher dispatcher = new FirebasePushDispatcher(new HttpClient(), configuration);
            var notification = new PushNotification
            {
                Title = "Título",
                Text = $"Push Notification from {nameof(FirebaseSendTest)}",
                Receiver = "etIUMOwerhM:APA91bHkhlxwex3qsxSi2WeVvgMv2TDCo1ap3ujJXynU_-GZl74TzsAbq_snr4VVqZbkbwY6wqIiCLH1uTEtHSBrS5VUcIL4yMSvOrz63f1l9h0nlCSjm_kHlVW3o1_YdF_LXVM1Pbe5",
                Data = new
                {
                    AppointmentId = Guid.NewGuid()
                }
            };

            var response = await dispatcher.Dispatch(notification);
            Assert.True(response.Status == Response.Success);
            Assert.False(response.Errors.Any());
        }
    }
}
