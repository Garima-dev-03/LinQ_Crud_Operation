using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Common.Models.Dtos
{
    public class WebApiUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreatedtDate { get; set; }
    }
}
