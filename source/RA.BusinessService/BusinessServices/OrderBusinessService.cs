using RA.BusinessService.Common;
using RA.BusinessService.Interfaces;
using RA.Kernel.Entities;
using RA.Persistence.Interfaces.Order;

namespace RA.BusinessService.BusinessServices
{
    public class OrderBusinessService : AbstractBusinessService<OrderEntity>, IOrderBusinessService
    {
        public IQueryOrderRepository _queryOrderRepository { get; set; }

        public ICommandOrderRepository _commandOrderRepository { get; set; }

        public OrderBusinessService(IQueryOrderRepository queryOrderRepository, ICommandOrderRepository commandOrderRepository) : base(queryOrderRepository, commandOrderRepository)
        {
            _queryOrderRepository = queryOrderRepository;
            _commandOrderRepository = commandOrderRepository;
        }
    }
}
