using DGIT9.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DGIT9.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<ProjectsData> ProjectsData1 { get; set; }

        public DbSet<ReposData> ReposData1 { get; set; }

        public DbSet<CommitsData> CommitsData { get; set; }

        public DbSet<ChangesData> ChangesData { get; set; }

        public DbSet<PullRequest> PullRequest1 { get; set; }
        public DbSet<UserData> UserData1 { get; set; }
    }
}
