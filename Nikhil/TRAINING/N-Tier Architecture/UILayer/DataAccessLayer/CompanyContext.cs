using DataAccessLayer.SQL_MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccessLayer
{
    public class CompanyContext : DbContext
    {
        public string _ConnStr = string.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TollPlus;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer(_ConnStr);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Salesman> Salesman { get; set; }
    }
}
