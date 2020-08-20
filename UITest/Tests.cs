using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
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

        #region Helpers
        private void ScrollDown(string objectName)
        {
            bool scrool = true;
            if (!string.IsNullOrEmpty(objectName))
            {
                scrool = !app.Query(e => e.Marked(objectName)).Any();
            }

            if (scrool)
            {
                if (this.platform == Platform.iOS)
                {
                    app.ScrollDown();

                }
                else
                {
                    app.ScrollDown(strategy: ScrollStrategy.Gesture);
                }
            }

        }
        private void ScrollUp(string objectName)
        {
            bool scrool = true;
            if (!string.IsNullOrEmpty(objectName))
            {
                scrool = !app.Query(e => e.Marked(objectName)).Any();
            }

            if (scrool)
            {
                if (this.platform == Platform.iOS)
                {
                    app.ScrollUp();

                }
                else
                {
                    app.ScrollUp(strategy: ScrollStrategy.Gesture);
                }
            }

        }
        #endregion



        [Test]
        public void ShouldBeAbleTologin()
        {
            //Arrange
            

            Assert.IsTrue(true);


        }

        public void OpenRepl()
        {

            app.Repl();

        }



    }
}
