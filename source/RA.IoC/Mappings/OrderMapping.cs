using AutoMapper;
using RA.Kernel.DtoObjects;
using RA.Persistence.Mssql.Entities;

namespace RA.IoC.Mappings
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<OrderDto, OrderEntity>().ReverseMap();
        }
    }
}
