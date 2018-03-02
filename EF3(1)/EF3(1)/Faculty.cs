using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3_1_
{
 public class Faculty
    {
        public int  facultyId{get;set;}
        public string facultyName { get; set;}
        public virtual ICollection<Person> students{get;set;}
        public Faculty()
        {
            students = new List<Person>();
        }
    }
}
