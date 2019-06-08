using AutoMapper;
using RA.Kernel.Common;
using RA.Persistence.Interfaces;

namespace RA.Persistence.Mssql.Common
{
    public abstract class AbstractCommandUnitOfWorkRepository<TDto, TEntity> : ICommandUnitOfWorkRepository<TDto>
        where TDto : BaseDto
        where TEntity : BaseEntity
    {
        public IMapper _mapper { get; set; }

        private MyDbContext _context { get; set; }

        public AbstractCommandUnitOfWorkRepository(IMapper mapper, MyDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public TDto Add(TDto dto)
        {
            return _mapper.Map<TDto>(_context.Add(_mapper.Map<TEntity>(dto)).Entity);
        }

        public void Remove(TDto dto)
        {
            //return _context.Remove(};
        }

        public TDto Update(TDto dto)
        {
            return _mapper.Map<TDto>(_context.Update(_mapper.Map<TEntity>(dto)).Entity);
        }
    }
}
