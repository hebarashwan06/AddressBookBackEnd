using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AddressBookDemo.DataMapping.Entities
{
    public class ApplicationdbContext:DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> options):base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
