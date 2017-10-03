using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class TinTuc
    {
        [Key]
        public string TinTucId { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayDang { get; set; }
        public string TaiKhoanId { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}