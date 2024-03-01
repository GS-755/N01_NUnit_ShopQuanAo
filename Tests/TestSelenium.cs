using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using N01_NUnit_ShopQuanAo.Models;
using N01_NUnit_ShopQuanAo.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace N01_NUnit_ShopQuanAo.Tests
{
    public class TestSelenium
    {
        private EdgeDriver driver;
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
