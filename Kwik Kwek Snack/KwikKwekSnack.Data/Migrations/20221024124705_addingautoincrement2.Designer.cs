﻿// <auto-generated />
using System;
using KwikKwekSnack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KwikKwekSnack.Data.Migrations
{
    [DbContext(typeof(SnackContext))]
    [Migration("20221024124705_addingautoincrement2")]
    partial class addingautoincrement2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KwikKwekSnack.Data.DrinkInOrder", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("DrinkId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("DrinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Ice")
                        .HasColumnType("bit");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<bool>("Straw")
                        .HasColumnType("bit");

                    b.HasKey("OrderID", "DrinkId");

                    b.HasIndex("DrinkName");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.Extra", b =>
                {
                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int?>("SnackInOrderOrderID")
                        .HasColumnType("int");

                    b.Property<int?>("SnackInOrderSnackID")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("SnackInOrderOrderID", "SnackInOrderSnackID");

                    b.ToTable("Extras");

                    b.HasData(
                        new
                        {
                            Name = 0,
                            Price = 0.5f
                        },
                        new
                        {
                            Name = 1,
                            Price = 0.5f
                        },
                        new
                        {
                            Name = 2,
                            Price = 0.5f
                        },
                        new
                        {
                            Name = 3,
                            Price = 0.5f
                        });
                });

            modelBuilder.Entity("KwikKwekSnack.Data.Item", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDrink")
                        .HasColumnType("bit");

                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"), 1L, 1);

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Name");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Name = "Coca Cola",
                            Description = "Coca Cola",
                            ImageURL = "~/img/coke.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1.5f
                        },
                        new
                        {
                            Name = "Fanta",
                            Description = "Fanta",
                            ImageURL = "~/img/fanta.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1.5f
                        },
                        new
                        {
                            Name = "Pepsi",
                            Description = "Pepsi Cola",
                            ImageURL = "~/img/pepsi.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1.5f
                        },
                        new
                        {
                            Name = "Coca Cola Zero",
                            Description = "Coca Cola Zero",
                            ImageURL = "~/img/coke0.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1.5f
                        },
                        new
                        {
                            Name = "Chocomel",
                            Description = "Chocomel",
                            ImageURL = "~/img/choccy.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1f
                        },
                        new
                        {
                            Name = "Fristi",
                            Description = "Fristi",
                            ImageURL = "~/img/fristi.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1f
                        },
                        new
                        {
                            Name = "Spa Rood",
                            Description = "Sprankelend water",
                            ImageURL = "~/img/kutwater.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1f
                        },
                        new
                        {
                            Name = "Spa Blauw",
                            Description = "Water",
                            ImageURL = "~/img/water.png",
                            IsAvailable = true,
                            IsDrink = true,
                            ItemID = 0,
                            Price = 1f
                        },
                        new
                        {
                            Name = "Frikandel",
                            Description = "Frikandel",
                            ImageURL = "~/img/frikandel.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 1.7f
                        },
                        new
                        {
                            Name = "Frikandel Speciaal",
                            Description = "Frikandel Speciaal",
                            ImageURL = "~/img/speciaal.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 2.1f
                        },
                        new
                        {
                            Name = "Kroket",
                            Description = "Kroket",
                            ImageURL = "~/img/kroket.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 1.7f
                        },
                        new
                        {
                            Name = "Kaassoufflé",
                            Description = "Kaassoufflé",
                            ImageURL = "~/img/kaas.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 1.85f
                        },
                        new
                        {
                            Name = "Bamischijf",
                            Description = "Bamischijf",
                            ImageURL = "~/img/bami.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 1.85f
                        },
                        new
                        {
                            Name = "Kipnuggets",
                            Description = "Kipnuggets",
                            ImageURL = "~/img/nuggets.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 2.05f
                        },
                        new
                        {
                            Name = "Hamburger",
                            Description = "Hamburger",
                            ImageURL = "~/img/burger.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 3.55f
                        },
                        new
                        {
                            Name = "Cheeseburger",
                            Description = "Cheeseburger",
                            ImageURL = "~/img/cburger.png",
                            IsAvailable = true,
                            IsDrink = false,
                            ItemID = 0,
                            Price = 4f
                        });
                });

            modelBuilder.Entity("KwikKwekSnack.Data.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TakeAway")
                        .HasColumnType("bit");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.SnackInOrder", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("SnackID")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("SnackName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderID", "SnackID");

                    b.HasIndex("SnackName");

                    b.ToTable("Snacks");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.DrinkInOrder", b =>
                {
                    b.HasOne("KwikKwekSnack.Data.Item", "Drink")
                        .WithMany("OrderWithDrinks")
                        .HasForeignKey("DrinkName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KwikKwekSnack.Data.Order", "Order")
                        .WithMany("Drinks")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drink");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.Extra", b =>
                {
                    b.HasOne("KwikKwekSnack.Data.SnackInOrder", null)
                        .WithMany("Extra")
                        .HasForeignKey("SnackInOrderOrderID", "SnackInOrderSnackID");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.SnackInOrder", b =>
                {
                    b.HasOne("KwikKwekSnack.Data.Order", "Order")
                        .WithMany("Snacks")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KwikKwekSnack.Data.Item", "Snack")
                        .WithMany("OrderWithSnacks")
                        .HasForeignKey("SnackName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Snack");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.Item", b =>
                {
                    b.Navigation("OrderWithDrinks");

                    b.Navigation("OrderWithSnacks");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.Order", b =>
                {
                    b.Navigation("Drinks");

                    b.Navigation("Snacks");
                });

            modelBuilder.Entity("KwikKwekSnack.Data.SnackInOrder", b =>
                {
                    b.Navigation("Extra");
                });
#pragma warning restore 612, 618
        }
    }
}
