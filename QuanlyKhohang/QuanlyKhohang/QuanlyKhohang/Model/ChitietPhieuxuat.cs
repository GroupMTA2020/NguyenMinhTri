namespace QuanlyKhohang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChitietPhieuxuat")]
    public partial class ChitietPhieuxuat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PXID { get; set; }

        public int? SPID { get; set; }

        public int? Soluong { get; set; }

        public virtual Phieuxuat Phieuxuat { get; set; }

        public virtual Sanpham Sanpham { get; set; }
    }
}
