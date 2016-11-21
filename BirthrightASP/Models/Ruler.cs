using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthrightASP.Models
{
    public class Ruler
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        [Required]
        [StringLength(10)]
        public string NameAbbreviation { get; set; }

        [Required]
        public ApplicationUser Player { get; set; }

    }
}