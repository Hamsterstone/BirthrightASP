using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Design;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace BirthrightASP.Models
{
    public class Province
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public Terrain Terrain { get; set; }
        public List<Terrain> SecondaryTerrain { get; set; }
        public Realm Realm { get; set; }

       // [Required]
        public int RealmId { get; set; }

        public string Loyalty { get; set; }
        [Required]
        public bool Road { get; set; }

    }
}