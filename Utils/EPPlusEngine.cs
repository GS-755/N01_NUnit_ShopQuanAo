using OfficeOpenXml;

namespace N01_NUnit_ShopQuanAo.Utils
{
    public class EPPlusEngine
    {
        private FileInfo _FileInfo { get; set; }
        public ExcelPackage _ExcelPackage { get; set; }
        public ExcelWorksheet _ExcelWorksheet { get; set; }

        public EPPlusEngine(string filePath, string sheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            this._FileInfo = new FileInfo(Path.GetFullPath(filePath));
            this._ExcelPackage = new ExcelPackage(this._FileInfo);
            this._ExcelWorksheet = this._ExcelPackage.Workbook.Worksheets[sheetName];
        }

        public int RowCount
        {
            get => this._ExcelWorksheet.Dimension.End.Column;
        }
        public int ColumnCount
        {
            get => this._ExcelWorksheet.Dimension.End.Row;
        }

        public string ReadExcelFile(int row, int col)
        {
            string data = string.Empty;
            try
            {
                data = this._ExcelWorksheet.Cells[row, col].Value?.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return data;
        }
        public void WriteExcelFile(Object data, int row, int col)
        {
            try
            {
                this._ExcelWorksheet.Cells[row, col].Value = data;
                this._ExcelPackage.SaveAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
