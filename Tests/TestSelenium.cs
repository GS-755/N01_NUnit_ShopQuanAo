namespace N01_NUnit_ShopQuanAo.Tests
{
    public class TestSelenium
    {
        #pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        private IWebDriver driver;

        [AllowNull]
        //để gán return của FindElement(By.xxx);
        private IWebElement expected; 
        [AllowNull]
        private IWebElement actual;

        [SetUp]
        public void Setup()
        {
            // Thay EdgeDriver thành driver đang sử dụng :) 
            this.driver = new EdgeDriver();
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl("https://microsoft.com");
        }

        [Test]
        [TearDown]
        public void TestWebDriver()
        {
            this.CloseBrowser();
            Assert.That(this.driver != null);
        }

        public void CloseBrowser() {
            this.driver.Quit();
        }
    }
}
