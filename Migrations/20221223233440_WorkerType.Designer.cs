﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using design_pattern.Data;

#nullable disable

namespace designpattern.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221223233440_WorkerType")]
    partial class WorkerType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("design_pattern.Models.Branches.Branch", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ManagerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.HasIndex("ManagerId")
                        .IsUnique();

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Name = "Italy Branch",
                            ManagerId = 1
                        },
                        new
                        {
                            Name = "Egypt Branch",
                            ManagerId = 2
                        },
                        new
                        {
                            Name = "Japan Branch",
                            ManagerId = 3
                        });
                });

            modelBuilder.Entity("design_pattern.Models.Meal.MealItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Seat")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("MealItems");
                });

            modelBuilder.Entity("design_pattern.Models.Meal.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TableNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TableNumber");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("design_pattern.Models.Menu.MenuCmp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MenuSectionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("MenuSectionId");

                    b.ToTable("menu_components", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("design_pattern.Models.Tables.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("TableNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TableNumber");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("design_pattern.Models.Tables.Table", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Seats")
                        .HasColumnType("INTEGER");

                    b.HasKey("Number");

                    b.HasIndex("BranchName");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("design_pattern.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Active");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.HasIndex("Type");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedAt = new DateTime(2022, 12, 23, 23, 34, 37, 665, DateTimeKind.Utc).AddTicks(9156),
                            Email = "domafayrouz@gmail.com",
                            Name = "Adham Fayrouz",
                            Password = "$2a$11$8joU.ZQT7eU3aXISdHuC4OvLvlcCpGgcDWUMfC6YaNbqH.o3fdJea",
                            Phone = "12345678",
                            Type = 1
                        },
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTime(2022, 12, 23, 23, 34, 38, 172, DateTimeKind.Utc).AddTicks(7107),
                            Email = "admin@gmail.com",
                            Name = "Admin",
                            Password = "$2a$11$uvvKVkvODJNLB8XKhdRvlOOrhxKepYbmRHZbB4sFgibh.K.svU5sy",
                            Phone = "123456789",
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedAt = new DateTime(2022, 12, 23, 23, 34, 38, 677, DateTimeKind.Utc).AddTicks(5555),
                            Email = "adhamfayrouz@gmail.com",
                            Name = "Adham Fayrouz",
                            Password = "$2a$11$5vlbQgM7pfAJLwWbZLFp6.DzpZQy5ZOYMAv.U3DsN.MRIDsacE3Qm",
                            Phone = "1234567",
                            Type = 1
                        });
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("salary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("workerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BranchName");

                    b.ToTable("Workers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("design_pattern.Models.Menu.MenuItem", b =>
                {
                    b.HasBaseType("design_pattern.Models.Menu.MenuCmp");

                    b.ToTable("menu_items", (string)null);
                });

            modelBuilder.Entity("design_pattern.Models.Menu.MenuSection", b =>
                {
                    b.HasBaseType("design_pattern.Models.Menu.MenuCmp");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasIndex("BranchName");

                    b.ToTable("menu_sections", (string)null);
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Cachier", b =>
                {
                    b.HasBaseType("design_pattern.Models.Workers.Worker");

                    b.ToTable("Cachiers", (string)null);
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Chef", b =>
                {
                    b.HasBaseType("design_pattern.Models.Workers.Worker");

                    b.ToTable("Chefs", (string)null);
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Manager", b =>
                {
                    b.HasBaseType("design_pattern.Models.Workers.Worker");

                    b.ToTable("Managers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchName = "Italy Branch",
                            Type = 0,
                            salary = 3000,
                            workerName = "Alberto"
                        },
                        new
                        {
                            Id = 2,
                            BranchName = "Egypt Branch",
                            Type = 0,
                            salary = 2500,
                            workerName = "Ali"
                        },
                        new
                        {
                            Id = 3,
                            BranchName = "Japan Branch",
                            Type = 0,
                            salary = 10000,
                            workerName = "Tanaka"
                        });
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Receptionist", b =>
                {
                    b.HasBaseType("design_pattern.Models.Workers.Worker");

                    b.ToTable("Receptionists", (string)null);
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Waiter", b =>
                {
                    b.HasBaseType("design_pattern.Models.Workers.Worker");

                    b.ToTable("Waiters", (string)null);
                });

            modelBuilder.Entity("design_pattern.Models.Branches.Branch", b =>
                {
                    b.HasOne("design_pattern.Models.Workers.Manager", "Manager")
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Branches.Branch", "ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("design_pattern.Models.Meal.MealItem", b =>
                {
                    b.HasOne("design_pattern.Models.Menu.MenuItem", "Item")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("design_pattern.Models.Meal.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("design_pattern.Models.Meal.Order", b =>
                {
                    b.HasOne("design_pattern.Models.Tables.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("design_pattern.Models.Menu.MenuCmp", b =>
                {
                    b.HasOne("design_pattern.Models.Menu.MenuSection", "MenuSection")
                        .WithMany("Items")
                        .HasForeignKey("MenuSectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuSection");
                });

            modelBuilder.Entity("design_pattern.Models.Tables.Reservation", b =>
                {
                    b.HasOne("design_pattern.Models.Tables.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("design_pattern.Models.Tables.Table", b =>
                {
                    b.HasOne("design_pattern.Models.Branches.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Worker", b =>
                {
                    b.HasOne("design_pattern.Models.Branches.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("design_pattern.Models.Menu.MenuItem", b =>
                {
                    b.HasOne("design_pattern.Models.Menu.MenuCmp", null)
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Menu.MenuItem", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("design_pattern.Models.Menu.MenuSection", b =>
                {
                    b.HasOne("design_pattern.Models.Branches.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("design_pattern.Models.Menu.MenuCmp", null)
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Menu.MenuSection", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Cachier", b =>
                {
                    b.HasOne("design_pattern.Models.Workers.Worker", null)
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Workers.Cachier", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Chef", b =>
                {
                    b.HasOne("design_pattern.Models.Workers.Worker", null)
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Workers.Chef", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Manager", b =>
                {
                    b.HasOne("design_pattern.Models.Workers.Worker", null)
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Workers.Manager", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Receptionist", b =>
                {
                    b.HasOne("design_pattern.Models.Workers.Worker", null)
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Workers.Receptionist", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("design_pattern.Models.Workers.Waiter", b =>
                {
                    b.HasOne("design_pattern.Models.Workers.Worker", null)
                        .WithOne()
                        .HasForeignKey("design_pattern.Models.Workers.Waiter", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("design_pattern.Models.Menu.MenuSection", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
