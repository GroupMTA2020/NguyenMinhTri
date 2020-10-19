namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phieuxuat")]
    public partial class Phieuxuat
    {
        [Key]
        public int IDPX { get; set; }

        public int KHID { get; set; }

        public int NVID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngayxuat { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }

        public virtual ChitietPhieuxuat ChitietPhieuxuat { get; set; }
    }
}
