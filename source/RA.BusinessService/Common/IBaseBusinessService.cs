using RA.Kernel.Common;

namespace RA.BusinessService.Common
{
    public interface IBaseBusinessService<TDto>
        where TDto : BaseDto
    {
        TDto Add(TDto input);

        TDto Update(TDto input);

        void Remove(TDto input);
    }
}
