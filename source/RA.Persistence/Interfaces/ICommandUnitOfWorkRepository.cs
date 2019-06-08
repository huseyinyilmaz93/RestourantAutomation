using RA.Kernel.Common;

namespace RA.Persistence.Interfaces
{
    public interface ICommandUnitOfWorkRepository<TDto>
        where TDto : BaseDto
    {
        TDto Add(TDto dto);

        TDto Update(TDto dto);

        void Remove(TDto dto);
    }
}
