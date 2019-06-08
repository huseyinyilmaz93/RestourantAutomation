using RA.Kernel.Common;
using RA.Persistence.Interfaces;

namespace RA.Persistence.Mssql.Common
{
    public abstract class AbstractQueryUnitOfWorkRepository<TDto, TEntity> : IQueryUnitOfWorkRepository<TDto, TEntity>
        where TDto : BaseDto
        where TEntity : BaseEntity
    {
        public AbstractQueryUnitOfWorkRepository()
        {
        }
    }
}
