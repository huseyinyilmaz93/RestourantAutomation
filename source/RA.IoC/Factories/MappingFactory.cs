using AutoMapper;
using RA.IoC.Mappings;

namespace RA.IoC.Factories
{
    public class MappingFactory : Profile
    {
        public static IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<OrderMapping>();
                cfg.AddProfile<OrderDetailMapping>();
            }).CreateMapper();
        }
    }
}
