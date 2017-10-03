using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class Khoa
    {
        [Key]
        public string KhoaId { get; set; }
        public string TenKhoa { get; set; }
        
        public virtual ICollection<SinhVien> SinhViens { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
        public virtual ICollection<Nganh> Nganhs { get; set; }

        public Khoa()
        {
            SinhViens = new HashSet<SinhVien>();
            GiangViens = new HashSet<GiangVien>();
            Nganhs = new HashSet<Nganh>();
        }
    }
}