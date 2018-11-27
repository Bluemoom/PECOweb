using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PECOweb.Model.Models
{
    [Table("Videos")]
    public class Video
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(256)]
        [Required]
        public string Url { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
