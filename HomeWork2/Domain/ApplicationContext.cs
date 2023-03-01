using HomeWork2.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Domain
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public ApplicationContext() => Database.EnsureCreated();
        //public ApplicationContext() => Database.EnsureDeleted();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Sber;Username=postgres;Password=postgres");
        }

    }
}
