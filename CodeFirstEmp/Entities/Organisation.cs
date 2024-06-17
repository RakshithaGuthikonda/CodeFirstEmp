using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEmp.Entities
{
    [Table("Organisation")]
    public class Organisation
    {
        [Key]
        
        public int Orgid { get; set; }
        public string Orgname { get; set; }
        public string experience { get; set; }

        [ForeignKey("Employee1")]
        public int empID { get; set; }
        public virtual Employee1 Employee1 { get; set; }    


    }
}
