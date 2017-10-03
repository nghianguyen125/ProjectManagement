using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjectManagement.Entities;

namespace ProjectManagement.Concrete
{
    public class ProjectEntities : DbContext
    {
        public ProjectEntities() : base("DefaultConnection")
        {

        }
        public DbSet<BinhLuan> BinhLuans { get; set; }
        public DbSet<DeTai> DeTais { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<HocKi> HocKis { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<Lich> Lichs { get; set; }
        public DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public DbSet<NamHoc> NamHocs { get; set; }
        public DbSet<NamHocHocKi> NamHocHocKis { get; set; }
        public DbSet<Nganh> Nganhs { get; set; }
        public DbSet<NhomSV> NhomSVs { get; set; }
        public DbSet<QuanLyLich> QuanLyLichs { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<TaiLieu> TaiLieus { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
        public DbSet<TrangThai> TrangThais { get; set; }

    }
}