using System;
using System.Collections.Generic;
using System.Text;

namespace Cow.io.OneSignal
{
    internal static class AppConsts
    {
        public static string SenderId = "";
        public static Guid AppId = Guid.Parse("");
        public static string RestApiKey = "";

        internal static class RestfulApi
        {
            public static string CreateNotification = "https://onesignal.com/api/v1/notifications";
        }
    }
}
