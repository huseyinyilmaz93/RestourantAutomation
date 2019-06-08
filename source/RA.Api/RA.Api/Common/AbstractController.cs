using Microsoft.AspNetCore.Mvc;
using RA.BusinessService.Common;
using RA.Kernel.Common;

namespace RA.Api.Common
{
    public class AbstractController<TDto> : ControllerBase,  IController<TDto>
        where TDto : BaseDto
    {
        private IBaseBusinessService<TDto> _baseBusinessService { get; set; }

        public AbstractController(IBaseBusinessService<TDto> baseBusinessService)
        {
            _baseBusinessService = baseBusinessService;
        }

        public TDto Add(TDto input)
        {
            return _baseBusinessService.Add(input);
        }

        public void Remove(TDto input)
        {
            _baseBusinessService.Remove(input);
        }

        public TDto Update(TDto input)
        {
            return _baseBusinessService.Add(input);
        }
    }
}
