using AutoMapper;
using RA.Kernel.DtoObjects;
using RA.Persistence.Interfaces.Order;
using RA.Persistence.Mssql.Common;
using RA.Persistence.Mssql.Entities;

namespace RA.Persistence.Mssql.Repositories.Order
{
    public class CommandOrderRepository : AbstractCommandUnitOfWorkRepository<OrderDto, OrderEntity>, ICommandOrderRepository
    {
        public CommandOrderRepository(IMapper mapper, MyDbContext context) : base(mapper, context)
        {
        }
    }
}
