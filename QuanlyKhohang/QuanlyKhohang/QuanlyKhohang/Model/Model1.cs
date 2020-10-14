namespace QuanlyKhohang.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Phieunhap> Phieunhaps { get; set; }
        public virtual DbSet<Phieuxuat> Phieuxuats { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<ChitietPhieunhap> ChitietPhieunhaps { get; set; }
        public virtual DbSet<ChitietPhieuxuat> ChitietPhieuxuats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
                .Property(e => e.Dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
                .HasMany(e => e.Phieuxuats)
                .WithRequired(e => e.Khachhang)
                .HasForeignKey(e => e.KHID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.taikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<Nhacungcap>()
                .Property(e => e.Dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Nhacungcap>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Nhacungcap>()
                .HasMany(e => e.Phieunhaps)
                .WithRequired(e => e.Nhacungcap)
                .HasForeignKey(e => e.NCCID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nhanvien>()
                .Property(e => e.Dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Nhanvien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Nhanvien>()
                .HasMany(e => e.Phieunhaps)
                .WithRequired(e => e.Nhanvien)
                .HasForeignKey(e => e.NVID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nhanvien>()
                .HasMany(e => e.Phieuxuats)
                .WithRequired(e => e.Nhanvien)
                .HasForeignKey(e => e.NVID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieunhap>()
                .HasOptional(e => e.ChitietPhieunhap)
                .WithRequired(e => e.Phieunhap);

            modelBuilder.Entity<Phieuxuat>()
                .HasOptional(e => e.ChitietPhieuxuat)
                .WithRequired(e => e.Phieuxuat);

            modelBuilder.Entity<Sanpham>()
                .HasMany(e => e.ChitietPhieunhaps)
                .WithOptional(e => e.Sanpham)
                .HasForeignKey(e => e.SPID);

            modelBuilder.Entity<Sanpham>()
                .HasMany(e => e.ChitietPhieuxuats)
                .WithOptional(e => e.Sanpham)
                .HasForeignKey(e => e.SPID);
        }
    }
}
