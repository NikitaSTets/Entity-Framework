using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
   public class ClassRoom
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1)]
        public string letter { get; set; }
        public ICollection<Person> persons { get; set; }
        
    }
}
