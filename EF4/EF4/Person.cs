using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF4
{
    [Table("PersonInfo")]
    public class Person
    {
        [Key,Required,MinLength(2),MaxLength(20)]
        public string Name { get; set; }
        
        public int Age { get; set; }
        public Factory factoryInfo { get; set;}
    }
}
