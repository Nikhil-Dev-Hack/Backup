﻿using CityInfoAPI.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfIntrest> PointOfIntrests { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
           : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                             .HasData(
                            new City()
                            {
                                Id = 1,
                                Name = "New York City",
                                Description = "The one with that big park."
                            },
                            new City()
                            {
                                Id = 2,
                                Name = "Antwerp",
                                Description = "The one with the cathedral that was never really finished."
                            },
                            new City()
                            {
                                Id = 3,
                                Name = "Paris",
                                Description = "The one with that big tower."
                            });


            modelBuilder.Entity<PointOfIntrest>()
              .HasData(
                new PointOfIntrest()
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Central Park",
                    Description = "The most visited urban park in the United States."

                },
                new PointOfIntrest()
                {
                    Id = 2,
                    CityId = 1,
                    Name = "Empire State Building",
                    Description = "A 102-story skyscraper located in Midtown Manhattan."
                },
                  new PointOfIntrest()
                  {
                      Id = 3,
                      CityId = 2,
                      Name = "Cathedral",
                      Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans."
                  },
                new PointOfIntrest()
                {
                    Id = 4,
                    CityId = 2,
                    Name = "Antwerp Central Station",
                    Description = "The the finest example of railway architecture in Belgium."
                },
                new PointOfIntrest()
                {
                    Id = 5,
                    CityId = 3,
                    Name = "Eiffel Tower",
                    Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."
                },
                new PointOfIntrest()
                {
                    Id = 6,
                    CityId = 3,
                    Name = "The Louvre",
                    Description = "The world's largest museum."
                }
                ); base.OnModelCreating(modelBuilder);
        }
    }
}
