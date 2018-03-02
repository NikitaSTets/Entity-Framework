using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car() { cost=1000,name="Volvo",year=2017};
            var car2 = new Car() { cost = 2000, name = "Audi", year = 2016 };
            var car3 = new Car() { cost = 3000, name = "BMW", year = 2015 };
            using (AutoShow db=new AutoShow())
            {
                db.CarTable.AddRange(new List<Car> { car1, car2, car3 });
                db.SaveChanges();
                var order1 = new Order() { Quantity = 1 };
                var order2 = new Order() { Quantity = 2 };
                order1.carCollection.Add(car1);
                order1.carCollection.Add(car2);
                order2.carCollection.Add(car3);
                db.OrderTable.AddRange(new List<Order> { order1,order2});
                db.SaveChanges();
                var list1 = db.OrderTable.ToList();
               
                foreach (var item in list1)
                {

                    Console.WriteLine("orderId={0},Quantity={1}", item.orderId, item.Quantity);
                    if (item.carCollection != null)
                    {
                        var a = item.carCollection.ToList();
                        foreach (var item1 in a)
                        {
                            Console.WriteLine("carId={0},cost={1},name={2},year={3}",item1.carId,item1.cost,item1.name,item1.year);
                        }
                    }
                    Console.WriteLine("----------------------------------------------");
                }

            }

            Console.WriteLine("Input smt");
            Console.ReadKey();
        }
    }
}
