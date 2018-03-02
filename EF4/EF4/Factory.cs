using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF4
{
    [Table("FactoryInfo")]
   public  class Factory
    {
        [Key,Required,MinLength(3),MaxLength(5)]
        public string Name { get; set; }
        [Required, MinLength(3), MaxLength(5)]
        public string Address { get; set; }
        public ICollection<Person> persons { get; set; }
        public Factory()
        {
            persons = new List<Person>();
        }
        
    }
}
