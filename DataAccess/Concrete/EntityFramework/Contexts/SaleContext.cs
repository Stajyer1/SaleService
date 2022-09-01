using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class SaleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.100.35;Database=Shop;User ID=sa;Pwd=Aa123456.!");
            //optionsBuilder.UseSqlServer("Data Source=192.168.100.35,1433;User ID=sa;Password=Aa123456.!;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=True");
        }

        
        public DbSet<Dealer> Dealer { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<CartItems> CartItems { get; set; }


    }
}
