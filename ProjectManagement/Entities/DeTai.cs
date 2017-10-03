using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class DeTai
    {
        [Key]
        public string DeTaiId { get; set; }
        public string TenDeTai { get; set; }
        public string MoTa { get; set; }
        public string GiangVienId { get; set; }
        public string NhomSVId { get; set; }

        public virtual NhomSV NhomSV { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual ICollection<TaiLieu> TaiLieus { get; set; }
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }

        public DeTai()
        {
            TaiLieus = new HashSet<TaiLieu>();
            BinhLuans = new HashSet<BinhLuan>();
        }
    }
}