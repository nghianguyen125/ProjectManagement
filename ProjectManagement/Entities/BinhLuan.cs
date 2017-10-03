using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class BinhLuan
    {
        [Key]
        public string BinhLuanId { get; set; }
        public string Ten { get; set; }
        public string TinNhan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string DeTaiId { get; set; }

        public virtual DeTai DeTai { get; set; }
    }
}