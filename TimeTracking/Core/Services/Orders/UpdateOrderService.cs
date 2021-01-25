using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;
using Common;

namespace Core.Services.Orders
{
    [AutoRegister]
   public class UpdateOrderService : IUpdateOrderService
    {
        public void Update(IEnumerable<OrderItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
