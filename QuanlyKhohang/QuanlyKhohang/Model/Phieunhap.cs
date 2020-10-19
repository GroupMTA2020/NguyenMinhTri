namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phieunhap")]
    public partial class Phieunhap
    {
        [Key]
        public int IDPN { get; set; }

        public int NCCID { get; set; }

        public int NVID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaynhap { get; set; }

        public virtual Nhacungcap Nhacungcap { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }

        public virtual ChitietPhieunhap ChitietPhieunhap { get; set; }
    }
}
