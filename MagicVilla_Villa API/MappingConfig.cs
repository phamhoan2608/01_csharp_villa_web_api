using AutoMapper;
using MagicVilla_Villa_API.Models;
using MagicVilla_Villa_API.Models.Dto;

namespace MagicVilla_Villa_API
{
    public class MappingConfig : Profile
    {

        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();

            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

        }
    }
}
