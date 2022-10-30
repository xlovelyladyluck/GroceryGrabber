﻿using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Models
{
    public class GroceryContext : DbContext
    {
        public GroceryContext(DbContextOptions<GroceryContext> options)
            : base(options)
        { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<GroceryItem> GroceryItems { get; set; }
        public DbSet<UsersLists> GroceryList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    UserId = 1,
                    UserName = "MorganC",
                    Name = "Morgan",
                    Password = "P@ssw0rd1"
                },
                new UserModel
                {
                    UserId = 2,
                    UserName = "LadyLuck",
                    Name = "Taylor",
                    Password = "P@ssw0rd1"
                },
                new UserModel
                {
                    UserId = 3,
                    UserName = "DeonD",
                    Name = "Deaon",
                    Password = "P@ssw0rd1"
                }
            );

            modelBuilder.Entity<GroceryItem>().HasData(
                new GroceryItem
                {
                    GroceryId = 1,
                    Name = "1lbs Hamburger",
                    Description = "Role of ground Hamburger Meat",
                    Department = "Meat",
                    Location = "Meat Counter/ Aisle 65"
                },
                new GroceryItem
                {
                    GroceryId = 2,
                    Name = "Lettuce",
                    Description = "1 Head of Iceburg Lettuce",
                    Department = "Produce",
                    Location = "Aisle 42"
                },
                new GroceryItem
                {
                    GroceryId = 3,
                    Name = "Apples",
                    Description = "5 lbs bag of Honey Crisp",
                    Department = "Produce",
                    Location = "Aisle 44"
                },
                new GroceryItem
                {
                    GroceryId = 4,
                    Name = "Sliced Turkey",
                    Description = "1 lbs of Turkey slices",
                    Department = "Deli",
                    Location = "Deli Counter/ Aisle 55"
                },
                new GroceryItem
                {
                    GroceryId = 5,
                    Name = "Bread",
                    Description = "1 loaf of White Whole Grain",
                    Department = "Bakery",
                    Location = "Aisle 20"
                }
             );

            modelBuilder.Entity<UsersLists>().HasData(
                new UsersLists
                {
                    id = 1,
                    UserID = 1,
                    GroceryId = 1
                });

        }

    }
}
