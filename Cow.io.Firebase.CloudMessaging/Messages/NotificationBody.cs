using Newtonsoft.Json;

namespace Cow.io.Firebase.CloudMessaging
{
    internal class NotificationBody
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
