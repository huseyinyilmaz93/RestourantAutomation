using RA.BusinessService.Common;
using RA.Kernel.Entities;
using RA.Persistence.Interfaces;

namespace RA.BusinessService.BusinessServices
{
    public class OrderDetailBusinessService : AbstractBusinessService<OrderDetailEntity>
    {
        public OrderDetailBusinessService(IBaseQueryRepository<OrderDetailEntity> baseQueryRepository, IBaseCommandRepository<OrderDetailEntity> baseCommandRepository) : base(baseQueryRepository, baseCommandRepository)
        {
        }
    }
}
