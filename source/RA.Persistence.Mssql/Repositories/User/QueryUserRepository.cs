using RA.Kernel.Entities;
using RA.Persistence.Interfaces.User;
using RA.Persistence.Mssql.Common;

namespace RA.Persistence.Mssql.Repositories.User
{
    public class QueryUserRepository : AbstractQueryRepository<UserEntity>, IQueryUserRepository
    {
        public QueryUserRepository(MyDbContext context) : base(context)
        {

        }
    }
}
