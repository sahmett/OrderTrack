using Microsoft.EntityFrameworkCore;
using OrderTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrack.Persistence.Context
{
    public class OrderTrackDbContext : DbContext
    {
       
        public DbSet<Address> Address { get; set; }
        public DbSet<Product> Product { get; set; }

        //public DbSet<Customer> Customer { get; set; }
        //public DbSet<Order> Order { get; set; }

        public OrderTrackDbContext(DbContextOptions<OrderTrackDbContext> dbContextOptions): base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            // Fluent API & konfig.

            // Customer ve Order arasındaki ilişki one-many

         
        }
    }
}
