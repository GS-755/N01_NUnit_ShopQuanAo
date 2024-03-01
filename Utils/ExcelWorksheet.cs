using N01_NUnit_ShopQuanAo.Interfaces;

namespace N01_NUnit_ShopQuanAo.Utils
{
    public sealed class ExcelWorksheet : IWorkbook
    {
        public static ExcelWorksheet
            instance { get; private set; } = new ExcelWorksheet();

        private Application excelApplication;
        private Workbook workbook;

        private ExcelWorksheet() {
            this.excelApplication = new Application();
            this.workbook = new Workbook();
        }

        //Static methods 
        public static bool WorkbookExists(string filePath)
        {
            try
            {
                return File.Exists(filePath);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);

                return false; 
            }
        }

        // After-instance methods
        public Workbook OpenWorkbook(string filePath)
        {
            try
            {
                this.workbook = this.
                    excelApplication.Workbooks.Open(filePath);

                return workbook;
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);

                return new Workbook();
            }
        }
        public IList<IShopQuanAo> GetData()
        {
            throw new NotImplementedException();
        }
        public void WriteData(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
