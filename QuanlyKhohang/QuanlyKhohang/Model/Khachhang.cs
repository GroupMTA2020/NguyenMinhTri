namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khachhang")]
    public partial class Khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khachhang()
        {
            Phieuxuats = new HashSet<Phieuxuat>();
        }

        [Key]
        public int IDKH { get; set; }

        [Required]
        [StringLength(300)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(300)]
        public string Diachi { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Dienthoai { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieuxuat> Phieuxuats { get; set; }
    }
}
