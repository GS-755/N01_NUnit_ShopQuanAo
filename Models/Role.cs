namespace N01_NUnit_ShopQuanAo.Models
{
    using N01_NUnit_ShopQuanAo.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("role")]
    public partial class Role : IShopQuanAo
    {
        public int ID { get; set; }
        public int parentId { get; set; }

        [StringLength(255)]
        public string accessName { get; set; }

        [StringLength(225)]
        public string description { get; set; }

        public string GropID { get; set; }
    }
}
