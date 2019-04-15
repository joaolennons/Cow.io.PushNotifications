using Newtonsoft.Json;

namespace Cow.io.Firebase.CloudMessaging
{
    internal class FirebasePushNotification
    {
        protected FirebasePushNotification()
        {
            Body = new NotificationBody();
        }

        [JsonProperty("registration_ids")]
        public string[] Receivers { get; set; }
        [JsonProperty("notification")]
        public NotificationBody Body { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }

        public class Builder
        {
            private readonly FirebasePushNotification _notification;
            public Builder()
            {
                _notification = new FirebasePushNotification();
            }
            public Builder WithTitle(string title)
            {
                _notification.Body.Title = title;
                return this;
            }

            public Builder WithText(string text)
            {
                _notification.Body.Text = text;
                return this;
            }

            public Builder WithData(object data)
            {
                _notification.Data = data;
                return this;
            }

            public Builder SendTo(string receiver)
            {
                _notification.Receivers = new[] { receiver };
                return this;
            }

            public FirebasePushNotification Build()
            {
                return _notification;
            }
        }
    }
}
