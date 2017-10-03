using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class GiangVien
    {
        [Key]
        public string GiangVienId { get; set; }
        public Boolean GioiTinh { get; set; }
        public string KhoaId { get; set; }
        public string NamHocId { get; set; }
        public string TaiKhoanId { get; set; }

        public virtual Khoa Khoa { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}