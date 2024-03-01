using N01_NUnit_ShopQuanAo.Interfaces;

namespace N01_NUnit_ShopQuanAo.Models
{
    public class Mgmail : IShopQuanAo
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
