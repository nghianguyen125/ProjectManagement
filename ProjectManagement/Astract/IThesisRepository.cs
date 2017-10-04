using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Entities;

namespace ProjectManagement.Astract
{
    public interface IThesisRepository
    {
        IQueryable<BinhLuan> BinhLuans { get; }
        IQueryable<DeTai> DeTai { get; }
        IQueryable<GiangVien> GiangViens { get; }
        IQueryable<HocKi> HocKis { get; }
        IQueryable<Khoa> Khoas { get; }
        IQueryable<Lich> Lichs { get; }
        IQueryable<LoaiTaiKhoan> LoaiTaiKhoans { get; }
        IQueryable<NamHoc> NamHocs { get; }
        IQueryable<NamHocHocKi> NamHocHocKis { get; }
        IQueryable<Nganh> Nganhs { get; }
        IQueryable<NhomSV> NhomSVs { get; }
        IQueryable<QuanLyLich> QuanLyLichs { get; }
        IQueryable<SinhVien> SinhViens { get; }
        IQueryable<TaiKhoan> TaiKhoans { get; }
        IQueryable<TaiLieu> TaiLieus { get; }
        IQueryable<TinTuc> TinTucs { get; }
        IQueryable<TrangThai> TrangThais { get; }
    }
}
