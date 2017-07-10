using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TestRecorderUITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void AddNumber()
        {
            app.EnterText("txtNum1Test", "10");
            app.EnterText("txtNum2Test", "20");

            app.Tap("btnAddTest");
        }

        [Test]
        public void NewTest()
        {
            app.Tap(x => x.Marked("txtNum1Test"));
            app.EnterText(x => x.Marked("txtNum1Test"), "10");
            app.Tap(x => x.Marked("txtNum2Test"));
            app.EnterText(x => x.Marked("txtNum2Test"), "20");
            app.Tap(x => x.Marked("btnAddTest"));
            app.EnterText(x => x.Marked("txtNum3Test"), "3");
            app.Tap(x => x.Marked("txtNum2Test"));
            app.EnterText(x => x.Marked("txtNum2Test"), "2");
            app.Tap(x => x.Marked("btnAddTest"));
            app.EnterText(x => x.Marked("txtNum3Test"), "2");
        }
    }
}

