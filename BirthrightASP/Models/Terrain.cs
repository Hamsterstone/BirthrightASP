using System.ComponentModel.DataAnnotations;

namespace BirthrightASP.Models
{
    public class Terrain
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

    }
}