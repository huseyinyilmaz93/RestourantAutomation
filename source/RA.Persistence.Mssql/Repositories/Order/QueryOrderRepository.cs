using RA.Kernel.DtoObjects;
using RA.Persistence.Interfaces.Order;
using RA.Persistence.Mssql.Common;
using RA.Persistence.Mssql.Entities;

namespace RA.Persistence.Mssql.Repositories.Order
{
    public class QueryOrderRepository : AbstractQueryUnitOfWorkRepository<OrderDto, OrderEntity>, IQueryOrderRepository
    {
    }
}
