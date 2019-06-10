using RA.Kernel.Common;
using RA.Persistence.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RA.Persistence.Mssql.Common
{
    public abstract class AbstractQueryRepository<TEntity> : IBaseQueryRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly MyDbContext _context;

        public AbstractQueryRepository(MyDbContext context)
        {
            _context = context;
        }

        public TEntity Get(int id)
        {
            return _context.Find<TEntity>(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().FirstOrDefault(expression);
        }

        public IQueryable<TEntity> GetList()
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

    }
}
