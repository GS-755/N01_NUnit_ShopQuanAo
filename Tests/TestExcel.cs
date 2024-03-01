using N01_NUnit_ShopQuanAo.Models;

namespace N01_NUnit_ShopQuanAo.Tests
{
    public class TestExcel
    {
        [SetUp]
        public void Setup()
        {
            Application application = new Application();
            Workbook workbook = new Workbook();
            Mmenu mmenu = new Mmenu();
            mmenu.();
        }

        [Test]
        public void TestOpen()
        {
            Assert.Pass();
        }
    }
}
