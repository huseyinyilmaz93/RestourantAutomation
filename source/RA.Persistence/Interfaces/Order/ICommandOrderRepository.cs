using RA.Kernel.DtoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Persistence.Interfaces.Order
{
    public interface ICommandOrderRepository : IBaseCommandRepository<OrderDto>
    {
    }
}
