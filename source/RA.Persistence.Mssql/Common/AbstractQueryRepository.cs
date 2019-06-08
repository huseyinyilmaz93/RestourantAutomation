using RA.Kernel.Common;
using RA.Persistence.Interfaces;

namespace RA.Persistence.Mssql.Common
{
    public abstract class AbstractQueryRepository<TDto> : IBaseQueryRepository<TDto>
        where TDto : BaseDto
    {

    }
}
