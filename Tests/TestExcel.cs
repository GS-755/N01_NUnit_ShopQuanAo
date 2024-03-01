namespace N01_NUnit_ShopQuanAo.Tests
{
    public class TestExcel
    {
        private Application excelApplication;
        private Workbook workbook;

        [SetUp]
        public void Setup()
        {
            this.excelApplication = ExcelWorksheet.
                Instance.ExcelApplication;
            this.workbook = new Workbook();
        }

        [Test]
        public void TestExcelBinaries()
        {
            Assert.That(this.excelApplication != null);
        }
    }
}
