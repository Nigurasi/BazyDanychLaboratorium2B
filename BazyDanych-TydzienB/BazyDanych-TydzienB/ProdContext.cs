using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanych_TydzienB
{
    public class ProdContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomersHistory> CustomersHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .Property(u => u.UnitPrice)
            .HasColumnType("Money");

            modelBuilder.Entity<CustomersHistory>().HasKey(c => new { c.HistoryID});

        }
    }

}
