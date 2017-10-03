using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class LoaiTaiKhoan
    {
        [Key]
        public string LoaiTaiKhoanId { get; set; }
        public string Loai { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }

        public LoaiTaiKhoan()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }
    }
}