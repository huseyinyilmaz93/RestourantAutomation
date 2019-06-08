using RA.Kernel.Common;

namespace RA.Api.Common
{
    public interface IController<TDto>
        where TDto : BaseDto
    {
        TDto Add(TDto input);

        TDto Update(TDto input);

        void Remove(TDto input);
    }
}
