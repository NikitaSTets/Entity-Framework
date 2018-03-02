using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF5
{
    [Table("BuildingInfo")]
public  class Building
    {
        [Key,Required, MinLength(1), MaxLength(20)]
        public string address { get; set;}
    }
}
