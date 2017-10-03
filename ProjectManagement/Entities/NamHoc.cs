using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class NamHoc
    {
        [Key]
        public string NamHocId { get; set; }
        public string Year { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
        public virtual ICollection<NamHocHocKi> NamHocHocKis { get; set; }

        public NamHoc()
        {
            SinhViens = new HashSet<SinhVien>();
            GiangViens = new HashSet<GiangVien>();
            NamHocHocKis = new HashSet<NamHocHocKi>();
        }
    }
}