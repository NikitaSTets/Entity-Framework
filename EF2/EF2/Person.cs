using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
 public class Person
    {
        public int personId { get; set; }
        public string FirstName{get;set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public ClassRoom clas { get; set; }
        public int clasId { get; set; }
        public Person() { }
         public Person(string firstName,string lastName,int Age,ClassRoom cl)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Age = Age;
            clas = cl;
            this.clasId=clas.Id;
        }
    }
}
