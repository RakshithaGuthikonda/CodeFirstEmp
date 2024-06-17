using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEmp.Entities
{
    [Table("Employee1")]
    public class Employee1
    {
        [Key]
        public int empID { get; set; }
        public string empname { get; set; }
        public int age { get; set; }
        public Organisation Organisation { get; set; }  
        
    }
}
