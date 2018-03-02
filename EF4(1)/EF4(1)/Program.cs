using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EF4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfDepartment, name,number;
            double cost;
            char a;
            using (DepartmentstoreDB db=new DepartmentstoreDB())
            {
                do
                {
                    //Console.WriteLine("input nameOfDepartment");
                    //nameOfDepartment = Console.ReadLine();
                    Console.WriteLine("Input name");
                    name = Console.ReadLine();
                    Console.WriteLine("Input number");
                    number = Console.ReadLine();
                    Console.WriteLine("Input cost");
                    cost = Convert.ToDouble(Console.ReadLine());
                    //db.departmets.Add(new Departmantstore() { Name = nameOfDepartment });
                    //db.SaveChanges();
                    var departmentArray = db.departmets.Include(q => q.products).ToArray();
                    Random rand = new Random();
                    db.products.Add(new Product() { Name = name, Cost = cost, Number = number, departmentstore = departmentArray[rand.Next(0, departmentArray.Length - 1)] });
                    db.SaveChanges();
                    Console.WriteLine("Depatments----------------------------");
                    foreach (var item in departmentArray)
                    {
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Department name={0}", item.Name);
                        var collection = item.products;
                        foreach (var item1 in collection)
                        {
                            Console.WriteLine("name={0},number={1},cost={2}", item1.Name, item1.Number, item1.Cost);
                        }
                        Console.WriteLine("-----------------------------------");
                    }
                    Console.WriteLine("Continue?(y/n)");
                    a = Convert.ToChar(Console.ReadLine());
                } while (a == 'y');
            }
        }
    }
}
