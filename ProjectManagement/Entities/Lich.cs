using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class Lich
    {
        [Key]
        public string LichId { get; set; }
        public DateTime MocNgay { get; set; }

        public virtual ICollection<QuanLyLich> QuanLyLichs { get; set; }

        public Lich()
        {
            QuanLyLichs = new HashSet<QuanLyLich>();
        }
    }
}