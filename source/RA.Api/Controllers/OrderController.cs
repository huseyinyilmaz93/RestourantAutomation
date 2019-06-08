using RA.Api.Common;
using RA.Api.Interfaces;
using RA.BusinessService.Interfaces;
using RA.Kernel.DtoObjects;

namespace RA.Api.Controllers
{
    public class OrderController : AbstractController<OrderDto>, IOrderController
    {
        public OrderController(IOrderBusinessService orderBusinessService) : base(orderBusinessService)
        {
            
        }
    }
}
