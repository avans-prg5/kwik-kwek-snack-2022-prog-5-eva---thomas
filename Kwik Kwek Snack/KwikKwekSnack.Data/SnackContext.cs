﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class SnackContext : DbContext
    {
        //  SnackRepo _repo = new SnackRepo();

        public DbSet<DrinkInOrder> Drinks { get; set; } = null!;
        public DbSet<Extra> Extras { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<SnackInOrder> Snacks { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<BeschikbareExtraInSnack> beschikbareExtraInSnacks { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost;Database=SnackbarKwikKwekKwak;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linked tables
            modelBuilder.Entity<DrinkInOrder>()
                .HasKey(t => new {t.OrderID, t.DrinkId});

            modelBuilder.Entity<DrinkInOrder>()
                .HasOne(pt => pt.Drink)
                .WithMany(p => p.OrderWithDrinks)
                .HasForeignKey(pt => pt.DrinkName);

            modelBuilder.Entity<DrinkInOrder>()
                .HasOne(pt => pt.Order)
                .WithMany(p => p.Drinks)
                .HasForeignKey(pt => pt.OrderID);

            modelBuilder.Entity<SnackInOrder>()
                .HasKey(t => new { t.OrderID, t.SnackID });

            modelBuilder.Entity<SnackInOrder>()
                .HasOne(pt => pt.Snack)
                .WithMany(p => p.OrderWithSnacks)
                .HasForeignKey(pt => pt.SnackName);

            modelBuilder.Entity<SnackInOrder>()
                .HasOne(pt => pt.Order)
                .WithMany(p => p.Snacks)
                .HasForeignKey(pt => pt.OrderID);

            modelBuilder.Entity<BeschikbareExtraInSnack>()
                .HasKey(t => new { t.ItemName, t.ExtraName });

            modelBuilder.Entity<BeschikbareExtraInSnack>()
                 .HasOne(pt => pt.Extra)
                 .WithMany(p => p.BeschikbareItems)
                 .HasForeignKey(pt => pt.ExtraName);

            modelBuilder.Entity<BeschikbareExtraInSnack>()
                .HasOne(p => p.SnackItem)
                .WithMany(pt => pt.BeschikbareExtras)
                .HasForeignKey(p => p.ItemName);
        
             
            //Seed data
            modelBuilder.Entity<Item>().HasData(
                new Item() { Name = "Coca Cola", Description = "Coca Cola", ImageURL = "~/img/coke.png", Price = 1.5f, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Fanta", Description = "Fanta", ImageURL = "~/img/fanta.png", Price = 1.5f, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Pepsi", Description = "Pepsi Cola", ImageURL = "~/img/pepsi.png", Price = 1.5f, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Coca Cola Zero", Description = "Coca Cola Zero", ImageURL = "~/img/coke0.png", Price = 1.5f, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Chocomel", Description = "Chocomel", ImageURL = "~/img/choccy.png", Price = 1, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Fristi", Description = "Fristi", ImageURL = "~/img/fristi.png", Price = 1, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Spa Rood", Description = "Sprankelend water", ImageURL = "~/img/kutwater.png", Price = 1, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Spa Blauw", Description = "Water", ImageURL = "~/img/water.png", Price = 1, IsDrink = true, IsAvailable = true },
                new Item() { Name = "Frikandel", Description = "Frikandel", ImageURL = "~/img/frikandel.png", Price = 1.7f, IsDrink = false, IsAvailable = true },
                new Item() { Name = "Frikandel Speciaal", Description = "Frikandel Speciaal", ImageURL = "~/img/speciaal.png", Price = 2.1f, IsDrink = false, IsAvailable = true },
                new Item() { Name = "Kroket", Description = "Kroket", ImageURL = "~/img/kroket.png", Price = 1.7f, IsDrink = false, IsAvailable = true },
                new Item() { Name = "Kaassoufflé", Description = "Kaassoufflé", ImageURL = "~/img/kaas.png", Price = 1.85f, IsDrink = false, IsAvailable = true },
                new Item() { Name = "Bamischijf", Description = "Bamischijf", ImageURL = "~/img/bami.png", Price = 1.85f, IsDrink = false, IsAvailable = true },
                new Item() { Name = "Kipnuggets", Description = "Kipnuggets", ImageURL = "~/img/nuggets.png", Price = 2.05f, IsDrink = false, IsAvailable = true },
                new Item() { Name = "Hamburger", Description = "Hamburger", ImageURL = "~/img/burger.png", Price = 3.55f, IsDrink = false, IsAvailable = true },
                new Item() { Name = "Cheeseburger", Description = "Cheeseburger", ImageURL = "~/img/cburger.png", Price = 4, IsDrink = false, IsAvailable = true }
                ) ;
        }
    }
}
