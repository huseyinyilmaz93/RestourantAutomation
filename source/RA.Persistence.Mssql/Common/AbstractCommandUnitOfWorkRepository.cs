using RA.Kernel.Common;
using RA.Persistence.Interfaces;
using System;

namespace RA.Persistence.Mssql.Common
{
    public abstract class AbstractCommandUnitOfWorkRepository<TEntity> : ICommandUnitOfWorkRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly MyDbContext _context;

        public AbstractCommandUnitOfWorkRepository(MyDbContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            TEntity saved = _context.Add(entity).Entity;
            _context.SaveChanges();
            return saved;
        }

        public TEntity Update(TEntity entity)
        {
            entity.ModifiedDate = DateTime.Now;
            TEntity saved = _context.Update(entity).Entity;
            _context.SaveChanges();
            return saved;
        }

        public void Remove(int id)
        {
            _context.Remove(new BaseEntity() { Id = id });
            _context.SaveChanges();
        }
    }
}
