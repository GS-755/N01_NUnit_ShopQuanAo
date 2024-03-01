using N01_NUnit_ShopQuanAo.Interfaces;

namespace N01_NUnit_ShopQuanAo.Utils
{
    public sealed class ExcelWorksheet : IWorkbook
    {
        public static ExcelWorksheet
            Instance { get; private set; } = new ExcelWorksheet();

        public Application ExcelApplication { get; set; }
        public Workbook Workbook { get; set; }

        private ExcelWorksheet() {
            this.ExcelApplication = new Application();
            this.Workbook = new Workbook();
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

        // After-Instance methods
        public Workbook OpenWorkbook(string filePath)
        {
            try
            {
                this.Workbook = this.
                    ExcelApplication.Workbooks.Open(filePath);

                return Workbook;
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
