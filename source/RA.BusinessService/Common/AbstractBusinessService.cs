using RA.Kernel.Common;
using RA.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessService.Common
{
    public class AbstractBusinessService<TDto> : IBaseBusinessService<TDto>
        where TDto : BaseDto
    {
        private IBaseQueryRepository<TDto> _baseQueryRepository;

        private IBaseCommandRepository<TDto> _baseCommandRepository;

        public AbstractBusinessService(IBaseQueryRepository<TDto> baseQueryRepository,
                                       IBaseCommandRepository<TDto> baseCommandRepository)
        {
            _baseQueryRepository = baseQueryRepository;
            _baseCommandRepository = baseCommandRepository;
        }

        public TDto Add(TDto input)
        {
            return _baseCommandRepository.Add(input);
        }

        public void Remove(TDto input)
        {
            _baseCommandRepository.Remove(input);
        }

        public TDto Update(TDto input)
        {
            return _baseCommandRepository.Update(input);
        }
    }
}
