namespace N01_NUnit_ShopQuanAo.Tests
{
    public class TestSelenium
    {
        private IWebDriver driver;
        [AllowNull]
        //để gán return của FindElement(By.xxx);
        private IWebElement expected; 
        [AllowNull]
        private IShopQuanAo actual;

        [SetUp]
        public void Setup()
        {
            // Cách sử dụng IShopQuanAo: 
            // (có thể thay thế CartItem bằng bất kỳ class nào)
            this.actual = new CartItem();
            // Thay EdgeDriver thành driver đang sử dụng :) 
            this.driver = new EdgeDriver();
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl("https://microsoft.com");
            this.driver.Quit();
        }

        [Test]
        public void TestWebDriver()
        {
            Assert.That(this.driver != null);
        }
    }
}
