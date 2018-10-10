using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Cow.Io.Firebase.CloudMessagingTest")]
namespace Cow.io.Firebase.CloudMessaging.Configuration
{
    internal class FirebaseApiConfiguration
    {
        public string SendUrl { get; set; }
        public string Token { get; internal set; }
    }
}
