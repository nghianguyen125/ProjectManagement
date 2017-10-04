using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagement.Astract;
using ProjectManagement.Concrete;
using ProjectManagement.Entities;

namespace ProjectManagement.Content
{
    public class ThesisRepository : IThesisRepository
    {
        private ProjectEntities context = new ProjectEntities();

        public IQueryable<BinhLuan> BinhLuans
        {
            get
            {
                return context.BinhLuans;
            }
        }

        public IQueryable<DeTai> DeTai
        {
            get
            {
                return context.DeTais;
            }
        }

        public IQueryable<GiangVien> GiangViens
        {
            get
            {
                return context.GiangViens;
            }
        }

        public IQueryable<HocKi> HocKis
        {
            get
            {
                return context.HocKis;
            }
        }

        public IQueryable<Khoa> Khoas
        {
            get
            {
                return context.Khoas;
            }
        }

        public IQueryable<Lich> Lichs
        {
            get
            {
                return context.Lichs;
            }
        }

        public IQueryable<LoaiTaiKhoan> LoaiTaiKhoans
        {
            get
            {
                return context.LoaiTaiKhoans;
            }
        }

        public IQueryable<NamHocHocKi> NamHocHocKis
        {
            get
            {
                return context.NamHocHocKis;
            }
        }

        public IQueryable<NamHoc> NamHocs
        {
            get
            {
                return context.NamHocs;
            }
        }

        public IQueryable<Nganh> Nganhs
        {
            get
            {
                return context.Nganhs;
            }
        }

        public IQueryable<NhomSV> NhomSVs
        {
            get
            {
                return context.NhomSVs;
            }
        }

        public IQueryable<QuanLyLich> QuanLyLichs
        {
            get
            {
                return context.QuanLyLichs;
            }
        }

        public IQueryable<SinhVien> SinhViens
        {
            get
            {
                return context.SinhViens;
            }
        }

        public IQueryable<TaiKhoan> TaiKhoans
        {
            get
            {
                return context.TaiKhoans;
            }
        }

        public IQueryable<TaiLieu> TaiLieus
        {
            get
            {
                return context.TaiLieus;
            }
        }

        public IQueryable<TinTuc> TinTucs
        {
            get
            {
                return context.TinTucs;
            }
        }

        public IQueryable<TrangThai> TrangThais
        {
            get
            {
                return context.TrangThais;
            }
        }
    }
}