using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EF4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,nameOfFactory,address;
            int age;
            char a;
            using (FactoryDB db=new FactoryDB())
            {
                do
                {
                    Console.WriteLine("Input person name");
                    name = Console.ReadLine();
                    Console.WriteLine("Input age");
                    age = Convert.ToInt32(Console.ReadLine());
                    db.Configuration.LazyLoadingEnabled = false;
                    //Console.WriteLine("Input name of factory");
                    //nameOfFactory = Console.ReadLine();
                    //Console.WriteLine("Input address");
                    //address = Console.ReadLine();
                    //var factory1 = new Factory() { Name = nameOfFactory, Address = address };
                    //db.factories.Add(factory1);
                    //db.SaveChanges();
                    var allFactories = db.factories.Include(f=>f.persons).ToArray();
                    int sizeFactories = db.factories.Count();
                    Random rand = new Random();
                    db.persons.Add(new Person() { Name = name, factoryInfo = allFactories[rand.Next(0, sizeFactories - 1)], Age = age });
                    db.SaveChanges();
                    Console.WriteLine("Factory info-----------------------------");
                    foreach (var item in allFactories)
                    {

                        Console.WriteLine("Name={0},Address={1}", item.Name, item.Address);
                        Console.WriteLine("------------------------------------");
                        var colect = item.persons.ToArray();
                        foreach (var item1 in colect)
                        {
                            Console.WriteLine("Age={0},Name={1}", item1.Age, item1.Name);
                        }
                        Console.WriteLine("------------------------------------");
                    }
                    Console.WriteLine("All persons info--------");
                        var colect1 = db.persons.ToList();
                        foreach (var item11 in colect1)
                        {
                            Console.WriteLine("Age={0},Name={1},factoryName={2}", item11.Age, item11.Name,item11.factoryInfo.Name);
                        }
                        Console.WriteLine("------------------------------------");
                    
                    Console.WriteLine("Continue?(y/n)");
                    a = Convert.ToChar(Console.ReadLine());
                } while (a=='y');              

            }
        }
    }
}
