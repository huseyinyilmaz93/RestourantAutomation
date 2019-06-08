using AutoMapper;
using RA.Kernel.DtoObjects;
using RA.Persistence.Mssql.Entities;

namespace RA.IoC.Mappings
{
    public class OrderDetailMapping : Profile
    {
        public OrderDetailMapping()
        {
            CreateMap<OrderDetailDto, OrderDetailEntity>().ReverseMap();
        }
    }
}
