#nuget
> Install-Package Cow.io.PushNotification -Version 1.0.0 -> abstractions <br />
> Install-Package Cow.io.Firebase.CloudMessaging -Version 1.0.0 -> fcm implementation

# Cow.io.PushNotifications
Provides simple structure for sending push notifications through firebase cloud messaging (FCM) for .net core

#Usage 

1. Use the IServiceCollection extension method from Cow.io.Firebase.CloudMessaging namespace:

```
services.AddFirebaseCloudMessagingDependency(o =>
{
     o.WithToken("{your-firebase-api-token-here");
});
```

2. Inject IPushNotificationDispatcher interface in the class you want to send push notifications

3. Use the following statement to send the message 

```
var notification = new PushNotification <br />
{
     Title = "{the notification title goes here}",<br />
     Text = $"{notification text goes here}",<br />
     Receiver = "${your-device-token-here}"<br />
};
```

var response = await dispatcher.Dispatch(notification);

That's it!
