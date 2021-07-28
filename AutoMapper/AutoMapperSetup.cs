using AutoMapper;
using AutoMapper_Enum.models;

namespace AutoMapper_Enum{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {       CreateMap<ModelB, ModelA>()
                    .ForMember(dest => dest.CodigoModelo, opt => opt.MapFrom(src => src.Codigo))
                    .ForMember(dest => dest.Tipo, opt => opt.MapFrom(src => src.Tipo))
                    .ReverseMap();
        }
    }
}