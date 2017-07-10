using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TestRecorderUITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(@"E:\Programes\XamarinTestRecorder\XamarinTestRecorder\XamarinTestRecorder.Android\bin\Release\XamarinTestRecorder.Android.apk")
                    .WaitTimes(new WaitTimer())
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

