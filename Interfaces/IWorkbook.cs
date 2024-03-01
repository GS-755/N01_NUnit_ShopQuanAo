namespace N01_NUnit_ShopQuanAo.Interfaces
{
    public interface IWorkbook
    {
        Workbook OpenWorkbook(string fileName);
        IList<IShopQuanAo> GetData();
        void WriteData(string fileName);
    }
}
