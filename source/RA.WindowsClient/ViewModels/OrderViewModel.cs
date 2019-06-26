using RA.Kernel.Entities;
using RA.WindowsClient.Common;
using System;
using System.Collections.Generic;

namespace RA.WindowsClient.ViewModels
{
    public class OrderViewModel : GenericViewModel<OrderEntity>
    {
        public OrderViewModel()
        {
            base.Items = new List<OrderEntity>
            {
                new OrderEntity{ Id = 1, OrderNumber = "OrderNumber", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new OrderEntity{ Id = 1, OrderNumber = "Test", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new OrderEntity{ Id = 1, OrderNumber = "Ahmedo", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new OrderEntity{ Id = 1, OrderNumber = "Memedo", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new OrderEntity{ Id = 1, OrderNumber = "Hamido", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
            };
        }
    }
}
