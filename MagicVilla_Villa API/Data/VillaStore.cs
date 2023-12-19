using MagicVilla_Villa_API.Models.Dto;

namespace MagicVilla_Villa_API.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
        {
            new VillaDTO{Id=1, Name="Beach View", Occupancy=4, Sqft=100},
            new VillaDTO{Id=2, Name="Moutainous View", Sqft=200, Occupancy=3}
         };
    }
}
