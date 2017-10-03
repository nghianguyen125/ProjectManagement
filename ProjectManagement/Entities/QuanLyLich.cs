using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class QuanLyLich
    {
        [Key]
        [Column(Order = 1)]
        public string LichId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string DeTaiId { get; set; }

        public string NoiDung { get; set; }

        public virtual DeTai DeTai { get; set; }
        public virtual Lich Lich { get; set; }
    }
}