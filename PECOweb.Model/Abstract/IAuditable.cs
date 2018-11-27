using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PECOweb.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdatedBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}
