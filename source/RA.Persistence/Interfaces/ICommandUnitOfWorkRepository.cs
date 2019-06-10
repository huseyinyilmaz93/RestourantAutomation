using RA.Kernel.Common;

namespace RA.Persistence.Interfaces
{
    public interface ICommandUnitOfWorkRepository<TEntity>
        where TEntity : BaseEntity
    {
        TEntity Add(TEntity dto);

        TEntity Update(TEntity dto);

        void Remove(int id);
    }
}
