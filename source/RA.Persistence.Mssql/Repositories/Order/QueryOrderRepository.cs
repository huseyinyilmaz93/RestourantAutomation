using RA.Kernel.Entities;
using RA.Persistence.Interfaces.Order;
using RA.Persistence.Mssql.Common;

namespace RA.Persistence.Mssql.Repositories.Order
{
    public class QueryOrderRepository : AbstractQueryRepository<OrderEntity>, IQueryOrderRepository
    {
        public QueryOrderRepository(MyDbContext context) : base(context)
        {

        }
    }
}
