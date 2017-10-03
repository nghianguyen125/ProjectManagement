using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class NhomSV
    {
        [Key]
        public string NhomSVId { get; set; }
        public string TenNhom { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }

        public NhomSV()
        {
            SinhViens = new HashSet<SinhVien>();
        }
    }
}