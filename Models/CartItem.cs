using N01_NUnit_ShopQuanAo.Interfaces;

namespace N01_NUnit_ShopQuanAo.Models
{
    [Serializable]
    public class CartItem : IShopQuanAo
    {
        public Mproduct product { get; set; }
        public int quantity { get; set; }

        public int countCart { get; set; }

        public string meThod { get; set; }

        public long priceTotal { get; set; }

        public long priceSaleee { get; set; }
        public bool f { get; set; }
    }
}
