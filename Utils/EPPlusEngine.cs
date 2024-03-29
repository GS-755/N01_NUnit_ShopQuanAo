namespace N01_NUnit_ShopQuanAo.Utils
{
    using OfficeOpenXml;
    
    public class EPPlusEngine
    {
        public static string ReadExcelFile(string filePath, string workSheet, int x, int y)
        {
            string data = "";
            try
            {
                FileInfo existingFile = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[workSheet];
                    // int colCount = worksheet.Dimension.End.Column;
                    // int rowCount = worksheet.Dimension.End.Row;
                    data = worksheet.Cells[x, y].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return data;
        }
        public static void WriteExcelFile(string filePath, string workSheet, Object data, int x, int y)
        {
            FileInfo existingFile = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[workSheet];
                // int colCount = worksheet.Dimension.End.Column;
                // int rowCount = worksheet.Dimension.End.Row;
                worksheet.Cells[x, y].Value = data;

                package.SaveAsync();
            }
        }
    }
}
