using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class TrangThai
    {
        [Key]
        public string TrangThaiId { get; set; }
        public Boolean Status { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }

        public TrangThai()
        {
            SinhViens = new HashSet<SinhVien>();
        }
    }
}