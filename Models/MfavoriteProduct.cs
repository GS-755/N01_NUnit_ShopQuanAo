using N01_NUnit_ShopQuanAo.Interfaces;

namespace N01_NUnit_ShopQuanAo.Models
{
    public class MfavoriteProduct: IShopQuanAo
    {
        public Mproduct favoriteProduct{ get; set; }
        public int status { get; set; }

    }
}
