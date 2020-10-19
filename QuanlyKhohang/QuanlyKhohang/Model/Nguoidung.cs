namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nguoidung")]
    public partial class Nguoidung
    {
        [Key]
        [StringLength(50)]
        public string taikhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string matkhau { get; set; }
    }
}
