using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Villa_API.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Occupancy { get; set; }

        public int Sqft { get; set; }

        public override string? ToString()
        {
            return "VillaDTO [id=" + this.Id + ", Name = " + this.Name + ", Occupancy = " + this.Occupancy + ", Sqft = " + this.Sqft+ "]";
        }
    }
}
