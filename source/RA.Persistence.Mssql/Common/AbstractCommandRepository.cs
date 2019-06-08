using RA.Kernel.Common;
using RA.Persistence.Interfaces;

namespace RA.Persistence.Mssql.Common
{
    public abstract class AbstractCommandRepository<TDto> : IBaseCommandRepository<TDto>
        where TDto : BaseDto
    {
        public ICommandUnitOfWorkRepository<TDto> _unitofWork { get; set; }

        public TDto Add(TDto input)
        {
            return _unitofWork.Add(input);
        }

        public void Remove(TDto input)
        {
            _unitofWork.Remove(input);
        }

        public TDto Update(TDto input)
        {
            return _unitofWork.Update(input);
        }
    }
}
