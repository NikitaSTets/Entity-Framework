using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_1_
{
  public  class Car
    {
        public int carId { get; set; }
        public string name{ get; set; }
        public double cost { get; set; }
        public int year  { get; set; }
        public ICollection<Order> orderCollection { get; set; }
        public Car()
        {
            orderCollection = new List<Order>();
        }
    }
}
