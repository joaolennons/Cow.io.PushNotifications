using Cow.io.Firebase.CloudMessaging.Configuration;
using Cow.io.PushNotification;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace Cow.io.Firebase.CloudMessaging
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFirebaseCloudMessagingDependency(this IServiceCollection services, Action<FirebaseApiConfigurationBuilder> options)
        {
            FirebaseApiConfigurationBuilder builder = new FirebaseApiConfigurationBuilder();
            options.Invoke(builder);
            var configuration = builder
                                .WithSendUrl(AppConsts.FirebaseSendUrl)
                                .Build();

            services.AddSingleton(configuration);
            services.AddTransient<HttpClient>();
            services.AddTransient<IPushNotificationDispatcher, FirebasePushDispatcher>();
            return services;
        }
    }
}
