using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF5
{
    
   public class House:Building
    {
        public int countOfRoom{get;set;}
        public int countOdDownstairs { get; set; }
    }
}
