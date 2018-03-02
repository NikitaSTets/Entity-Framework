using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new  DropCreateDatabaseIfModelChanges<KekDB>());
            string a;
            string name, family;
            int age;
           
            using (KekDB db=new KekDB())
            {
                //try
                //{
                do
                {
                    Console.WriteLine("Input char");
                    a = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Input age");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input name");
                    name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Input family");
                    family = Convert.ToString(Console.ReadLine());
                    var cl = new ClassRoom() { letter = a };
                    db.ClassTable.Add(cl);
                    db.SaveChanges();
                    var ar = db.ClassTable.ToArray();
                    var pr = new Person(name, family, age, ar[0]);
                    db.PersonTable.Add(pr);
                    db.SaveChanges();
                    var list1 = db.ClassTable.ToList();
                    foreach (var item in list1)
                    {
                        Console.WriteLine("id={0},letter={1}", item.Id, item.letter);
                    }
                    var list2 = db.PersonTable.ToList();
                    foreach (var item in list2)
                    {
                        Console.WriteLine("Age={0},FirstName={2},LastName={3},clasId={4}", item.Age, item.clas, item.FirstName, item.LastName, item.clasId);
                    }
                } while (true);
            }
            
                //catch (Exception)
                //{

                //    Console.WriteLine("Error");
                //}
           // }
            Console.WriteLine("Input smt");
            Console.ReadKey();
        }
    }
}
