using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EF3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name, lastName;
            using (FacultDB db=new FacultDB())
            {
                
                //    var fc1 = new Faculty() { facultyName = "FKSIS" };
                //    var fc2 = new Faculty() { facultyName = "FTK" };
                //    var fc3 = new Faculty() { facultyName = "FITY" };
                //    var fc4 = new Faculty() { facultyName = "FKP" };
                //    var fc5 = new Faculty() { facultyName = "IEF" };
                //    var fc6 = new Faculty() { facultyName = "FRE" };
                //try {

                //    db.FacultyTable.AddRange(new List<Faculty>() {fc1,fc2,fc3,fc4,fc5,fc6});
                //    db.SaveChanges();
                //     }
              //  catch (Exception) { }
                var ar=db.FacultyTable.Include(f=>f.students).ToList();
                Random rand = new Random();
                Console.WriteLine("Input age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input name");
                name = Console.ReadLine();
                Console.WriteLine("Input lastName");
                lastName = Console.ReadLine();
                var pr1 = new Person() { Age = age, faculty=ar[rand.Next(0,5)],LastName=lastName,Name=name };
                db.StudentTable.Add(pr1);
                db.SaveChanges();
                Console.WriteLine("All-----------------------");
                var list = db.StudentTable.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("Age={0},faculty={1},name={2},lastName={3}",item.Age,item.faculty.facultyName,item.Name,item.LastName);
                }
                Console.WriteLine("Sort-----------------------");
                var a = db.StudentTable.First();
                Console.WriteLine("First Age={0},faculty={1},name={2},lastName={3}", a.Age, a.faculty.facultyName, a.Name, a.LastName);
               var  list1= db.StudentTable.OrderBy(f=>f.Age);
                foreach (var item in list1)
                {
                    Console.WriteLine("Age={0},faculty={1},name={2},lastName={3}", item.Age, item.faculty.facultyName, item.Name, item.LastName);
                }
                Console.WriteLine("-------------");
                //db.SaveChanges();
                 list = db.StudentTable.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("Age={0},faculty={1},name={2},lastName={3}", item.Age, item.faculty.facultyName, item.Name, item.LastName);
                }
                Console.WriteLine("Student count={0}",db.StudentTable.Count());
                Console.WriteLine("Student min age={0}",db.StudentTable.Min(p=>p.Age));
                Console.WriteLine("Student max age={0}", db.StudentTable.Max(p => p.Age));
                Console.WriteLine("Student average age={0}", db.StudentTable.Average(p => p.Age));
                var selec = db.FacultyTable.Select(f=>new {f.facultyName, f.students });
                Console.WriteLine("Select--------------------------------");
                foreach (var item in selec)
                {
                    Console.WriteLine("{0}",item.facultyName);
                    var c = item.students.ToList();
                    foreach (var item1 in c)
                    {
                        Console.WriteLine("Age={0},faculty={1},name={2},lastName={3}", item1.Age, item1.faculty.facultyName, item1.Name, item1.LastName);
                    }
                }
                Console.WriteLine("Find");
                var d = db.FacultyTable.Find(2);
                Console.WriteLine("faculty name={0}",d.facultyName);
            }

            Console.WriteLine("Input smt");
            Console.ReadKey();
        }
    }
}
