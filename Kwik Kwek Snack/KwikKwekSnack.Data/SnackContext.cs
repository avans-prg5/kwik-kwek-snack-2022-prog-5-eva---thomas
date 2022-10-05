using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class SnackContext : DbContext
    {

        public DbSet<Drink> Drinks { get; set; } = null!;
        public DbSet<Extra> Extras { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Size> Sizes { get; set; } = null!;
        public DbSet<Snack> Snacks { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost;Database=SnackbarKwikKwekKwak;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed data
            modelBuilder.Entity<Drink>().HasData(
                new Drink() { Name = "Coca Cola", Description = "Coca Cola", ImageURL = "~/img/coke.png", Price = 1.5f, Ice = false, Size = null, Straw = false },
                new Drink() { Name = "Fanta", Description = "Fanta", ImageURL = "~/img/fanta.png", Price = 1.5f, Ice = false, Size = null, Straw = false },
                new Drink() { Name = "Pepsi", Description = "Pepsi Cola", ImageURL = "~/img/pepsi.png", Price = 1.5f, Ice = false, Size = null, Straw = false },
                new Drink() { Name = "Coca Cola Zero", Description = "Coca Cola Zero", ImageURL = "~/img/coke0.png", Price = 1.5f, Ice = false, Size = null, Straw = false },
                new Drink() { Name = "Chocomel", Description = "Chocomel", ImageURL = "~/img/choccy.png", Price = 1, Ice = false, Size = null, Straw = false },
                new Drink() { Name = "Fristi", Description = "Fristi", ImageURL = "~/img/fristi.png", Price = 1, Ice = false, Size = null, Straw = false },
                new Drink() { Name = "Spa Rood", Description = "Sprankelend water", ImageURL = "~/img/kutwater.png", Price = 1, Ice = false, Size = null, Straw = false },
                new Drink() { Name = "Spa Blauw", Description = "Water", ImageURL = "~/img/water.png", Price = 1, Ice = false, Size = null, Straw = false }
                ); ;

            modelBuilder.Entity<Snack>().HasData(
                new Snack() { Name = "Frikandel", Description = "Frikandel", ImageURL = "~/img/frikandel.png", Price = 1.7f, Extras = null },
                new Snack() { Name = "Frikandel Speciaal", Description = "Frikandel Speciaal", ImageURL = "~/img/speciaal.png", Price = 2.1f, Extras = null },
                new Snack() { Name = "Kroket", Description = "Kroket", ImageURL = "~/img/kroket.png", Price = 1.7f, Extras = null },
                new Snack() { Name = "Kaassoufflé", Description = "Kaassoufflé", ImageURL = "~/img/kaas.png", Price = 1.85f, Extras = null },
                new Snack() { Name = "Bamischijf", Description = "Bamischijf", ImageURL = "~/img/bami.png", Price = 1.85f, Extras = null },
                new Snack() { Name = "Kipnuggets", Description = "Kipnuggets", ImageURL = "~/img/nuggets.png", Price = 2.05f, Extras = null },
                new Snack() { Name = "Hamburger", Description = "Hamburger", ImageURL = "~/img/burger.png", Price = 3.55f, Extras = null },
                new Snack() { Name = "Cheeseburger", Description = "Cheeseburger", ImageURL = "~/img/cburger.png", Price = 4, Extras = null }
                );;

            modelBuilder.Entity<Extra>().HasData(
                new Extra() { Extras = "Kaas" },
                new Extra() { Extras = "Ui" },
                new Extra() { Extras = "Sla" },
                new Extra() { Extras = "Tomaat" }
                );

            modelBuilder.Entity<Size>().HasData(
                new Size() { sizes = "S" },
                new Size() { sizes = "M" },
                new Size() { sizes = "L" },
                new Size() { sizes = "XL" }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status() { statuses = "Wachtrij" },
                new Status() { statuses = "Wordt bereid" },
                new Status() { statuses = "Gereed" }
                );
        }
    }
}
