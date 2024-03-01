namespace N01_NUnit_ShopQuanAo.Models
{
    using N01_NUnit_ShopQuanAo.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("slider")]
    public partial class Mslider : IShopQuanAo
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        [StringLength(100)]
        public string position { get; set; }

        [StringLength(100)]
        public string img { get; set; }

        public int? orders { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime created_at { get; set; }

        public int? created_by { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime updated_at { get; set; }

        public int? updated_by { get; set; }

        public int status { get; set; }
    }
}
