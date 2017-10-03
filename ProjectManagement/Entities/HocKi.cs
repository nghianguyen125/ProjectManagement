using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class HocKi
    {
        [Key]
        public string HocKiId { get; set; }
        public string Semester { get; set; }

        public virtual ICollection<NamHocHocKi> NamHocHocKis { get; set; }

        public HocKi()
        {
            NamHocHocKis = new HashSet<NamHocHocKi>();
        }
    }
}