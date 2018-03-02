using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_1_
{
   public class Order
    {
        public int orderId { get; set; }
        public int Quantity { get; set; }
        public ICollection<Car> carCollection {get;set;}
        public Order()
        {
            carCollection = new List<Car>();
        }
    }
}
