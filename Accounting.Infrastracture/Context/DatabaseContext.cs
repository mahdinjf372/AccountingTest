using Accounting.Application.Interfaces.Context;
using Accounting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Infrastracture.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options):base(options){}

        public DbSet<User> User { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsRemove);
            modelBuilder.Entity<Transaction>().HasQueryFilter(u => !u.IsRemove);
            modelBuilder.Entity<Customer>().HasQueryFilter(u => !u.IsRemove);
            modelBuilder.Entity<TransactionType>().HasQueryFilter(u => !u.IsRemove);

            modelBuilder.Entity<TransactionType>().HasData(new List<TransactionType>
            {
                new TransactionType{ Id = 1 , InsertTime = DateTime.Now, Title="پرداخت"},
                new TransactionType{ Id = 2 , InsertTime = DateTime.Now, Title="دریافت"}
            });
        }

    }
}
