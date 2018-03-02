using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EF5
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BuildDB>());
            string address;
            int rooms, downstairs;
            char a;
            using (BuildDB db = new BuildDB())
            {
                do
                { 
                    Console.WriteLine("Input address");
                    address = Console.ReadLine();
                    Console.WriteLine("Input count of room");
                    rooms = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input count of downstairs");
                    downstairs = Convert.ToInt32(Console.ReadLine());
                    //db.Buildings.Add(new Building() { address=address});
                    //db.SaveChanges();
                    //var buildings = db.Buildings.ToArray();
                    db.Houses.Add(new House() { address = address, countOdDownstairs = downstairs, countOfRoom = rooms });
                    db.SaveChanges();
                   
                    Console.WriteLine("Continue?(y/n)");
                    a = Convert.ToChar(Console.ReadLine());
            } while (a == 'y') ;
        }
        
        }
    }
}
