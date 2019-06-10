using RA.Kernel.Common;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RA.BusinessService.Common
{
    public interface IBaseBusinessService<TEntity>
        where TEntity : BaseEntity
    {
        TEntity Get(int id);

        TEntity Get(Expression<Func<TEntity, bool>> expression);

        IQueryable<TEntity> GetList();

        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> expression);

        TEntity Save(TEntity input);

        void Remove(int id);
    }
}
