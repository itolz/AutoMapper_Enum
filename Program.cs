using System;
using AutoMapper;
using System.Web;

namespace AutoMapper_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
        //    var mapper =  new AutoMapperSetup().CreateMap(); 

        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<models.ModelB, models.ModelA>()
            .ForMember(dest => dest.CodigoModelo, opt => opt.MapFrom(src => src.Codigo))
            .ReverseMap();
        });

        IMapper mapper = config.CreateMapper();

            var itemA = new models.ModelA{CodigoModelo = "A", Tipo = models.Tipo.Basica};


            var result = mapper.Map<models.ModelB>(itemA);



            Console.WriteLine(result.GetType().Name);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
