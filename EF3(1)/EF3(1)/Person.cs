using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3_1_
{
    public class Person
    {
        public int personId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Faculty faculty { get; set; }
        public int Age { get; set; }

    }
}
