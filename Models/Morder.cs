namespace N01_NUnit_ShopQuanAo.Models
{
    using N01_NUnit_ShopQuanAo.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("order")]
    public partial class Morder : IShopQuanAo
    {
        [Key]
        public int ID { get; set; }
        public string code { get; set; }
        public int userid { get; set; }
        public DateTime created_ate { get; set; }
        public DateTime? exportdate { get; set; }
        public string deliveryaddress { get; set; }
        public string deliveryname { get; set; }
        public string deliveryphone { get; set; }
        public string deliveryemail { get; set; }
        public string deliveryPaymentMethod { get; set; }
        public int StatusPayment { get; set; }
        public DateTime updated_at { get; set; }
        public int? updated_by { get; set; }
        public int status { get; set; }
    }
}
