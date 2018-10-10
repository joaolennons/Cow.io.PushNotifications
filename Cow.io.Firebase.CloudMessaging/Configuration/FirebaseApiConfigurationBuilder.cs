namespace Cow.io.Firebase.CloudMessaging.Configuration
{
    public class FirebaseApiConfigurationBuilder
    {
        private readonly FirebaseApiConfiguration _configuration;
        public FirebaseApiConfigurationBuilder()
        {
            _configuration = new FirebaseApiConfiguration();
        }
        public FirebaseApiConfigurationBuilder WithToken(string token)
        {
            _configuration.Token = token;
            return this;
        }

        public FirebaseApiConfigurationBuilder WithSendUrl(string url)
        {
            _configuration.SendUrl = url;
            return this;
        }

        internal FirebaseApiConfiguration Build()
        {
            return _configuration;
        }
    }
}
