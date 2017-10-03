using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class SinhVien
    {
        [Key]
        public string SinhVienId { get; set; }
        public Boolean GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int SoTCHT { get; set; }
        public int SoTCCL { get; set; }
        public string KhoaId { get; set; }
        public string NhomSVId { get; set; }
        public string TrangThaiId { get; set; }
        public string NamHocId { get; set; }
        public string TaiKhoanId { get; set; }

        public virtual TrangThai TrangThai { get; set; }
        public virtual NamHoc NamHoc { get; set; }
        public virtual Khoa Khoa { get; set; }
        public virtual NhomSV NhomSV { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}