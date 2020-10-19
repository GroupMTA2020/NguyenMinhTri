namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhacungcap")]
    public partial class Nhacungcap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhacungcap()
        {
            Phieunhaps = new HashSet<Phieunhap>();
        }

        [Key]
        public int IDNCC { get; set; }

        [Required]
        [StringLength(300)]
        public string TenNCC { get; set; }

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
        public virtual ICollection<Phieunhap> Phieunhaps { get; set; }
    }
}
