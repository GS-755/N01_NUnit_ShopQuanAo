namespace N01_NUnit_ShopQuanAo.Models
{
    using N01_NUnit_ShopQuanAo.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("link")]
    public partial class Link : IShopQuanAo
    {
        [Key]
        public int ID { get; set; }

        public string slug { get; set; }

        public int tableId { get; set; }

        public string type { get; set; }

        public int parentId { get; set; }
    }
}
