using RA.Kernel.Entities;
using RA.Persistence.Interfaces.User;
using RA.Persistence.Mssql.Common;

namespace RA.Persistence.Mssql.Repositories.User
{
    public class CommandUserRepository : AbstractCommandUnitOfWorkRepository<UserEntity>, ICommandUserRepository
    {
        public CommandUserRepository(MyDbContext context) : base(context)
        {
        }


    }
}
