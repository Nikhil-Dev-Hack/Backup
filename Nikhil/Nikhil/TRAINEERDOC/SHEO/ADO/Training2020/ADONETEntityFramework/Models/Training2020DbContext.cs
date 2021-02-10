using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ADONETEntityFramework.Models
{
    public class Training2020DbContext : DbContext
    {

        static string _connStr = string.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            optionsBuilder.UseSqlServer(_connStr);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }



    }
}
