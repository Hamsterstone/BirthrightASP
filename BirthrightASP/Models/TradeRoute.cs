using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace BirthrightASP.Models
{
    public class TradeRoute
    {
        public int Id { get; set; }
        [Required]
        public Province SourceProvince { get; set; }
        public Province DestinationProvince { get; set; }
        [Required]
        public Realm OwnerRealm { get; set; }

        
        public int SourceProvinceId { get; set; }

        
        public int DestinationProvinceId { get; set; }
        public int OwnerRealmId { get; set; }
    }
}