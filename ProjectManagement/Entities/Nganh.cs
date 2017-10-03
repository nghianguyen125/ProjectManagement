using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagement.Entities
{
    public class Nganh
    {
        [Key]
        public string NganhId { get; set; }
        public string TenNganh { get; set; }
        public string KhoaId { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}