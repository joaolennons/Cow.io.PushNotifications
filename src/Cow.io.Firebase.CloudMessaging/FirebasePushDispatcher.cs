using Cow.io.Firebase.CloudMessaging.Configuration;
using Cow.io.PushNotification;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Cow.Io.Firebase.CloudMessagingTest")]
namespace Cow.io.Firebase.CloudMessaging
{
    internal class FirebasePushDispatcher : IPushNotificationDispatcher
    {
        private readonly HttpClient _client;
        private readonly FirebaseApiConfiguration _configuration;
        public FirebasePushDispatcher(HttpClient client, FirebaseApiConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("key", configuration.Token);
        }
        public async Task<IPushNotificationResponse> Dispatch(IPushNotification notification, CancellationToken cancellation)
        {
            var push = new FirebasePushNotification.Builder()
                       .WithTitle(notification.Title)
                       .WithText(notification.Text)
                       .WithData(notification.Data)
                       .SendTo(notification.Receiver)
                       .Build();

            var promise = await _client.PostAsync(_configuration.SendUrl, new StringContent(JsonConvert.SerializeObject(push), Encoding.Default, "application/json"));
            var response = await promise.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PushNotificationResponse>(response);
        }
    }
}
