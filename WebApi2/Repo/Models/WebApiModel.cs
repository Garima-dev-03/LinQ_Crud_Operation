using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models
{
    public class WebApiModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        public DateTime UpdateDate{ get; set; }
        public DateTime CreatedtDate { get; set; }

    }
}
