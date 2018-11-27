using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PECOweb.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { set; get; }
        [MaxLength(256)]
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
