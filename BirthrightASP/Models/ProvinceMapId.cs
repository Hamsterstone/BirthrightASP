using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthrightASP.Models
{
    public class ProvinceMapId
    {
        public int Id { get; set; }
        [Required]
        public Province Province { get; set; }
        [Required]
        public int MapIdNumber { get; set; }

        public int ProvinceId { get; set; }
    }
}