using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.ViewModels
{
    public class OrderListViewModel
    {
        public List<Order> Orders { get; set; }
        public class Order
        {
            public int Id { get; set; }
            public string CustomerName { get; set; }
            public DateTime? OrderDate { get; set; }

        }
    }
}
