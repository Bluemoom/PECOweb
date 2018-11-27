using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PECOweb.Model.Models
{
    [Table("Companies")]
    public class Company
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string Lat { get; set; }

        [Required]
        [MaxLength(20)]
        public string Leng{ get; set; }

        [Required]
        [MaxLength(50)]
        public string Mobile { get; set; }
        public bool Status { get; set; }

    }
}
