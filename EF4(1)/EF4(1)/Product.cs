using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF4_1_
{
   public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Number { get; set; }
        public Departmantstore departmentstore { get; set; }
    }
}
