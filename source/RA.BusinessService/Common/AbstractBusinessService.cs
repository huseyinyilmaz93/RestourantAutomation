using RA.Kernel.Common;
using RA.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessService.Common
{
    public class AbstractBusinessService<TEntity> : IBaseBusinessService<TEntity>
        where TEntity : BaseEntity
    {
        private IBaseQueryRepository<TEntity> _baseQueryRepository;

        private IBaseCommandRepository<TEntity> _baseCommandRepository;

        public AbstractBusinessService(IBaseQueryRepository<TEntity> baseQueryRepository,
                                       IBaseCommandRepository<TEntity> baseCommandRepository)
        {
            _baseQueryRepository = baseQueryRepository;
            _baseCommandRepository = baseCommandRepository;
        }


        public TEntity Get(int id)
        {
            return _baseQueryRepository.Get(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return _baseQueryRepository.Get(expression);
        }

        public IQueryable<TEntity> GetList()
        {
            return _baseQueryRepository.GetList();
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> expression)
        {
            return _baseQueryRepository.GetList(expression);
        }

        public TEntity Save(TEntity input)
        {
            return (input.Id == 0)
                ? _baseCommandRepository.Add(input)
                : _baseCommandRepository.Update(input);
                
        }

        public void Remove(int id)
        {
            _baseCommandRepository.Remove(id);
        }

    }
}
