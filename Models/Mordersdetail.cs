namespace N01_NUnit_ShopQuanAo.Models
{
    using N01_NUnit_ShopQuanAo.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ordersdetail")]
    public partial class Mordersdetail : IShopQuanAo
    {
        [Key]
        public int ID { get; set; }

        public int orderid { get; set; }

        public int productid { get; set; }

        public double price { get; set; }

        public int quantity { get; set; }

        public int priceSale { get; set; }

        public double amount { get; set; }
    }
}
