using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class TaiLieu
    {
        [Key]
        public string TaiLieuId { get; set; }
        public string TenTaiLieu { get; set; }
        public string DeTaiId { get; set; }

        public virtual DeTai DeTai { get; set; }
    }
}