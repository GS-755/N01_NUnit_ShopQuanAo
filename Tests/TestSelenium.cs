namespace N01_NUnit_ShopQuanAo.Tests
{
    public class TestSelenium
    {
        #pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Thay EdgeDriver thành driver đang sử dụng :) 
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl("http://localhost:22222");
        }

        [Test]
        public void TestWebDriver()
        {
            Assert.That(this.driver != null);
        }

        [TearDown]
        public void TearDown() {
            this.driver.Quit();
        }
    }
}
