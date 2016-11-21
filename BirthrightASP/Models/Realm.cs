using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthrightASP.Models
{
    public class Realm
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        public Ruler Ruler { get; set; }

        [Required]
        public int RulerId { get; set; }

    }
}