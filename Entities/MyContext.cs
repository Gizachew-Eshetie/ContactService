using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class MyContext : DbContext
    {
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=GIZE\SQLEXPRESS;Initial Catalog=ContactDB;");
        }
    }
}
