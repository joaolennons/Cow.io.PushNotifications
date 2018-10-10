using Cow.io.PushNotification;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Cow.io.Firebase.CloudMessaging
{
    internal class PushNotificationResponse : IPushNotificationResponse
    {
        [JsonProperty("multicast_id")]
        public string MulticastId { get; set; }
        [JsonProperty("success")]
        public int Success { get; set; }
        [JsonProperty("failure")]
        public int Failure { get; set; }
        [JsonProperty("canonical_ids")]
        public int CanonicalIds { get; set; }
        [JsonProperty("results")]
        public List<PushNotificationResult> Results { get; set; }
        public Response Status => Success > 0 && Failure == 0 ? Response.Success : Success > 0 && Failure > 0 ? Response.PartiallySuccessful : Response.Failure;
        public List<string> Errors => Results.FindAll(o => !string.IsNullOrEmpty(o.Error)).Select(o => o.Error).ToList();
    }

    internal class PushNotificationResult
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
