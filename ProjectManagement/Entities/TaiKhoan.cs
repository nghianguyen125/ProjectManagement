using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class TaiKhoan
    {
        [Key]
        public string TaiKhoanId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public float SDTK { get; set; }
        public string LoaiTaiKhoanId { get; set; }

        public virtual ICollection<TinTuc> TinTucs { get; set; }
        public virtual LoaiTaiKhoan LoaiTaiKhoan { get; set; }

        public TaiKhoan()
        {
            TinTucs = new HashSet<TinTuc>();
        }
    }
}