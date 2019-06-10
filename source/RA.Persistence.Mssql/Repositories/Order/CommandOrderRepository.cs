using RA.Kernel.Entities;
using RA.Persistence.Interfaces.Order;
using RA.Persistence.Mssql.Common;

namespace RA.Persistence.Mssql.Repositories.Order
{
    public class CommandOrderRepository : AbstractCommandUnitOfWorkRepository<OrderEntity>, ICommandOrderRepository
    {
        public CommandOrderRepository(MyDbContext context) : base(context)
        {
        }
    }
}
