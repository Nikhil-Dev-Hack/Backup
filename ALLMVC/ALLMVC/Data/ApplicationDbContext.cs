using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ALLMVC.Models;

namespace ALLMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ALLMVC.Models.Employee> Employee { get; set; }
        public DbSet<ALLMVC.Models.Department> Department { get; set; }
    }
}
