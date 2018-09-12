﻿// <auto-generated />
using EFCoreForDummies.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreForDummies.Migrations
{
    [DbContext(typeof(BreweryContext))]
    [Migration("20180912085638_RecipesSeeding")]
    partial class RecipesSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreForDummies.Data.Brewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FavouriteBeerType");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Upkeep");

                    b.HasKey("Id");

                    b.ToTable("Brewers");

                    b.HasData(
                        new { Id = 1, FavouriteBeerType = 2, FirstName = "Georgi", LastName = "Dimitrov", Upkeep = 8 },
                        new { Id = 2, FavouriteBeerType = 1, FirstName = "Velio", LastName = "Ivanov", Upkeep = 3 },
                        new { Id = 3, FavouriteBeerType = 3, FirstName = "Krasimir", LastName = "Kostadinov", Upkeep = 5 },
                        new { Id = 4, FavouriteBeerType = 2, FirstName = "Vladislav", LastName = "Konovski", Upkeep = 4 },
                        new { Id = 5, FavouriteBeerType = 1, FirstName = "Ivan", LastName = "Stefanov", Upkeep = 2 },
                        new { Id = 6, FavouriteBeerType = 1, FirstName = "Boris", LastName = "Penev", Upkeep = 6 }
                    );
                });

            modelBuilder.Entity("EFCoreForDummies.Data.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hops");

                    b.Property<int>("Malt");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.Property<int>("Water");

                    b.Property<int>("Yeast");

                    b.Property<int>("Yield");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new { Id = 1, Hops = 180, Malt = 12, Name = "Big Amber", Type = 3, Water = 82, Yeast = 40, Yield = 60 },
                        new { Id = 2, Hops = 140, Malt = 8, Name = "Medium Amber", Type = 3, Water = 56, Yeast = 25, Yield = 40 },
                        new { Id = 3, Hops = 80, Malt = 6, Name = "Small Weiss", Type = 2, Water = 50, Yeast = 20, Yield = 34 },
                        new { Id = 4, Hops = 160, Malt = 12, Name = "Big Weiss", Type = 2, Water = 100, Yeast = 45, Yield = 68 },
                        new { Id = 5, Hops = 120, Malt = 8, Name = "Medium Lager", Type = 1, Water = 56, Yeast = 30, Yield = 36 },
                        new { Id = 6, Hops = 90, Malt = 6, Name = "Small Lager", Type = 1, Water = 42, Yeast = 20, Yield = 26 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
