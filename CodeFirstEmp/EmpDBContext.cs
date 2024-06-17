using CodeFirstEmp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEmp
{
    public class EmpDBContext : DbContext
    {
        public EmpDBContext() : base("EmployeeEntities")
        {

        }
        public DbSet<Employee1> Employee1s { get; set; }

        public DbSet<Organisation>Organisations { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee1>().HasOptional(E => E.Organisation).WithRequired(AD => AD.Employee);
            modelBuilder.Entity<Organisation>().HasOptional(e => e.Employee1).WithRequired(o => o.Organisation);
            base.OnModelCreating(modelBuilder);
        }
    }
}
