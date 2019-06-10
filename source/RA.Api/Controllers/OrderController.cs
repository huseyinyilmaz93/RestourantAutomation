using RA.Api.Common;
using RA.Api.Interfaces;
using RA.BusinessService.Interfaces;
using RA.Kernel.Entities;

namespace RA.Api.Controllers
{
    public class OrderController : AbstractController<OrderEntity>, IOrderController
    {
        public OrderController(IOrderBusinessService orderBusinessService) : base(orderBusinessService)
        {
            
        }
    }
}
