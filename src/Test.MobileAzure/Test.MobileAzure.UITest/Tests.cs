using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace Test.MobileAzure.UITest
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest() 
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                .Debug()
                //.ApkFile("../../../Test.MobileAzure/bin/Release/Test.MobileAzure.Test.MobileAzure.apk")
                //.ApkFile()
                .InstalledApp("Test.MobileAzure.Test.MobileAzure")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.WaitForElement(c => c.Marked("MyButton"));
            app.Tap(c => c.Marked("MyButton"));
            //app.Repl();
            app.WaitForElement(c => c.Marked("MyButton").Text("1 clicks!"));
            //app.Screenshot("First screen.");
        }

        //[Test]
        //public void FailedAppLaunches()
        //{
        //    app.WaitForElement(c => c.Marked("MyButton"));
        //    app.Tap(c => c.Marked("MyButton"));
        //    //app.Repl();
        //    app.WaitForElement(c => c.Marked("MyButton").Text("xxx!"));
        //    //app.Screenshot("First screen.");
        //}
    }
}

