# Cow.io.PushNotifications
Provides simple structure for sending push notifications through firebase cloud messaging (FCM) for .net core

#Usage 

1. Use the IServiceCollection extension method from Cow.io.Firebase.CloudMessaging namespace:

services.AddFirebaseCloudMessagingDependency(o =>
{
     o.WithToken("{your-firebase-api-token-here");
});

2. Inject IPushNotificationDispatcher interface in the class you want to send push notifications

3. Use the following statement to send the message 

var notification = new PushNotification
 {
	Title = "{the notification title goes here}",
        Text = $"{notification text goes here}",
        Receiver = "${your-device-token-here}"
};

var response = await dispatcher.Dispatch(notification);

That's it!
