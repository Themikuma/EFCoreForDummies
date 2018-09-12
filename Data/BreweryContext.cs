using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreForDummies.Data
{
    public class BreweryContext : DbContext
    {
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=Brewery; Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brewer>().HasData(new Brewer()
            {
                Id = 1,
                FavouriteBeerType = BeerType.Wiess,
                FirstName = "Georgi",
                LastName = "Dimitrov",
                Upkeep = 8
            },
            new Brewer()
            {
                Id = 2,
                FavouriteBeerType = BeerType.Lager,
                FirstName = "Velio",
                LastName = "Ivanov",
                Upkeep = 3

            },
            new Brewer()
            {
                Id = 3,
                FavouriteBeerType = BeerType.Amber,
                FirstName = "Krasimir",
                LastName = "Kostadinov",
                Upkeep = 5

            },
            new Brewer()
            {
                Id = 4,
                FavouriteBeerType = BeerType.Wiess,
                FirstName = "Vladislav",
                LastName = "Konovski",
                Upkeep = 4

            },
            new Brewer()
            {
                Id = 5,
                FavouriteBeerType = BeerType.Lager,
                FirstName = "Ivan",
                LastName = "Stefanov",
                Upkeep = 2

            },
            new Brewer()
            {
                Id = 6,
                FavouriteBeerType = BeerType.Lager,
                FirstName = "Boris",
                LastName = "Penev",
                Upkeep = 6

            });
            modelBuilder.Entity<Recipe>().HasData(new Recipe()
            {
                Id = 1,
                Name="Big Amber",
                Malt=12,
                Hops=180,
                Type=BeerType.Amber,
                Water=82,
                Yeast=40,
                Yield=60
            },
            new Recipe()
            {
                Id = 2,
                Name = "Medium Amber",
                Malt = 8,
                Hops = 140,
                Type = BeerType.Amber,
                Water = 56,
                Yeast = 25,
                Yield = 40
            },
            new Recipe()
            {
                Id = 3,
                Name = "Small Weiss",
                Malt = 6,
                Hops = 80,
                Type = BeerType.Wiess,
                Water = 50,
                Yeast = 20,
                Yield = 34
            },
            new Recipe()
            {
                Id = 4,
                Name = "Big Weiss",
                Malt = 12,
                Hops = 160,
                Type = BeerType.Wiess,
                Water = 100,
                Yeast = 45,
                Yield = 68
            },
            new Recipe()
            {
                Id = 5,
                Name = "Medium Lager",
                Malt = 8,
                Hops = 120,
                Type = BeerType.Lager,
                Water = 56,
                Yeast = 30,
                Yield = 36
            },
            new Recipe()
            {
                Id = 6,
                Name = "Small Lager",
                Malt = 6,
                Hops = 90,
                Type = BeerType.Lager,
                Water = 42,
                Yeast = 20,
                Yield = 26
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
