using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCartPortal.Models;

namespace ShoppingCartPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ShoppingCartPortal.Models.Product> Product { get; set; }
        public DbSet<ShoppingCartPortal.Models.Cart> Cart { get; set; }
        public DbSet<ShoppingCartPortal.Models.Order> Order { get; set; }

        public DbSet<ShoppingCartPortal.Models.OrderDetail> OrderDetail { get; set; }
    }
}
