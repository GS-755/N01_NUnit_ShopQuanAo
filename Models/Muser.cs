namespace N01_NUnit_ShopQuanAo.Models
{
    using N01_NUnit_ShopQuanAo.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("user")]
    public partial class Muser : IShopQuanAo
    {
        public int ID { get; set; }

        
        [StringLength(255)]
        public string fullname { get; set; }

        
        [StringLength(225)]
        public string username { get; set; }

        
        [StringLength(64)]
        public string password { get; set; }

        
        [StringLength(255)]
        public string email { get; set; }

        [StringLength(5)]
        public string gender { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(100)]
        public string img { get; set; }

        public int access { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime created_at { get; set; }

        public int created_by { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime updated_at { get; set; }

        public int updated_by { get; set; }

        public int status { get; set; }
    }
}
