﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinTestRecorderUITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .WaitTimes(new WaitTimer())
                    .ApkFile(@"E:\Programes\XamarinTestRecorder\XamarinTestRecorder\XamarinTestRecorder.Android\bin\Release\XamarinTestRecorder.Android.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}
