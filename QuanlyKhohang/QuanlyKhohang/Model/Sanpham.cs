namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            ChitietPhieunhaps = new HashSet<ChitietPhieunhap>();
            ChitietPhieuxuats = new HashSet<ChitietPhieuxuat>();
        }

        [Key]
        public int IDSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        public int NCCID { get; set; }

        public double Gia { get; set; }

        public int Soluong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChitietPhieunhap> ChitietPhieunhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChitietPhieuxuat> ChitietPhieuxuats { get; set; }
    }
}
