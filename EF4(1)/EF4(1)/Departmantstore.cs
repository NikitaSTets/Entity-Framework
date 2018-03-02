using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF4_1_
{
   public class Departmantstore
    {

        public string Name { get; set; }
        public ICollection<Product> products { get; set; }
        public Departmantstore()
        {
            products = new List<Product>();
        }
    }
}
