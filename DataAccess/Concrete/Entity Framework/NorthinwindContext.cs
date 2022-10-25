using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entity_Framework
{
     public class NorthinwindContext: DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
