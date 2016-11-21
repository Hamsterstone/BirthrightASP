using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthrightASP.Models
{
    public class Unit
    {
        public int Id { get; set; }

        [Required]
        public UnitType Type { get; set; }

    }
}