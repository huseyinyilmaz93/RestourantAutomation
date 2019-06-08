using RA.Kernel.Common;

namespace RA.Persistence.Interfaces
{
    public interface IQueryUnitOfWorkRepository<TDto, TEntity>
        where TDto : BaseDto
        where TEntity : BaseEntity
    {
    }
}
