using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class NamHocHocKi
    {
        [Key]
        [Column(Order = 1)]
        public string HocKiId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string NamHocId { get; set; }

        public virtual NamHoc NamHoc { get; set; }
        public virtual HocKi HocKi { get; set; }
    }
}