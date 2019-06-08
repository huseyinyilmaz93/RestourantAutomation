using RA.BusinessService.Common;
using RA.Kernel.DtoObjects;
using RA.Persistence.Interfaces;

namespace RA.BusinessService.BusinessServices
{
    public class OrderDetailBusinessService : AbstractBusinessService<OrderDetailDto>
    {
        public OrderDetailBusinessService(IBaseQueryRepository<OrderDetailDto> baseQueryRepository, IBaseCommandRepository<OrderDetailDto> baseCommandRepository) : base(baseQueryRepository, baseCommandRepository)
        {
        }
    }
}
