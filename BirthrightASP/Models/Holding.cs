using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthrightASP.Models
{
    public class Holding
    {
        public int Id { get; set; }
        public Province Province { get; set; }
        public int ProvinceId { get; set; }
        public HoldingType Type { get; set; }
        public int Size { get; set; }
        public Realm Owner { get; set; }
        public int OwnerId { get; set; }


    }
}