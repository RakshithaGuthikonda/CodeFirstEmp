using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstEmp.Entities;

namespace CodeFirstEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpDBContext db = new EmpDBContext();   
            Organisation o= new Organisation();
            o.Orgid = int.Parse(Console.ReadLine());
            o.Orgname = Console.ReadLine();
            o.experience = Console.ReadLine(); 
            o.empID = 3;
            db.Organisations.Add(o);
            db.SaveChanges();
        }
    }
}
