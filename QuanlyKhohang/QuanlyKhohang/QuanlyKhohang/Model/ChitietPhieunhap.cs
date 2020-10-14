namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChitietPhieunhap")]
    public partial class ChitietPhieunhap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PNID { get; set; }

        public int? SPID { get; set; }

        public int? Soluong { get; set; }

        public virtual Phieunhap Phieunhap { get; set; }

        public virtual Sanpham Sanpham { get; set; }
    }
}
