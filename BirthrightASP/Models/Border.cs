using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BirthrightASP.Models
{
    public class Border
    {
        public Province Province1 { get; set; }
        public Province Province2 { get; set; }
        public bool RiverBorder { get; set; }
        [Key]
        [Column(Order = 1)]
        public int Province1Id { get; set; }
        [Key]
        [Column(Order = 2)]
        public int Province2Id { get; set; }
    }
}