using Ecommerce.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DatabaseContext.DatabaseContext
{
    public class EcommerceDatabaseContext : DbContext
    {
        private IConfiguration _configuration;
        public EcommerceDatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchesOrder> PurchesOrders { get; set; }
        public DbSet<PurchesOrderItem> PurchesOrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("AppConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        //fluent api? nasıl kulanılır?
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Shop>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>()
                .HasOne<Shop>(c => c.Shop)//birebir ilişki
                .WithMany(d => d.Products)//bireçok ilişki
                .HasForeignKey(x => x.ShopId);//yabancı anahtar

            base.OnModelCreating(modelBuilder);

            //query filter
            modelBuilder.Entity<Product>().HasQueryFilter(c => c.IsDeleted == false);
        }

    }
}
