﻿// <auto-generated />
using System;
using KzStock.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KzStock.Migrations
{
    [DbContext(typeof(StockDbContext))]
    [Migration("20190523150224_AddSeedForReportAndFKForPurchase")]
    partial class AddSeedForReportAndFKForPurchase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KzStock.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<bool>("Enabled");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "martin@kzsoftworks.com",
                            Enabled = true,
                            LastName = "Mato",
                            Name = "Martin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "james@kzsoftworks.com",
                            Enabled = true,
                            LastName = "Bond",
                            Name = "James"
                        },
                        new
                        {
                            Id = 3,
                            Email = "fulano@kzsoftworks.com",
                            Enabled = true,
                            LastName = "Detal",
                            Name = "Fulano"
                        },
                        new
                        {
                            Id = 4,
                            Email = "victor@kzsoftworks.com",
                            Enabled = true,
                            LastName = "Pons",
                            Name = "Victor"
                        });
                });

            modelBuilder.Entity("KzStock.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Stock");

                    b.Property<double>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Galletas Oreo",
                            Stock = 10,
                            UnitPrice = 50.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Coca Cola",
                            Stock = 8,
                            UnitPrice = 35.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Agua Helada",
                            Stock = 15,
                            UnitPrice = 45.0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Jugo Ades",
                            Stock = 3,
                            UnitPrice = 22.0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Helado Palito",
                            Stock = 5,
                            UnitPrice = 12.0
                        });
                });

            modelBuilder.Entity("KzStock.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("ProductId");

                    b.Property<int>("ReportId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ReportId");

                    b.ToTable("Purchase");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1,
                            EmployeeId = 1,
                            ProductId = 1,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 1000,
                            EmployeeId = 1,
                            ProductId = 2,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 3,
                            Amount = 3,
                            EmployeeId = 1,
                            ProductId = 3,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 4,
                            Amount = 1,
                            EmployeeId = 4,
                            ProductId = 3,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 5,
                            Amount = 1000,
                            EmployeeId = 4,
                            ProductId = 2,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 3,
                            EmployeeId = 4,
                            ProductId = 4,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 7,
                            Amount = 1,
                            EmployeeId = 2,
                            ProductId = 2,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 8,
                            Amount = 1000,
                            EmployeeId = 2,
                            ProductId = 1,
                            ReportId = 0
                        },
                        new
                        {
                            Id = 9,
                            Amount = 3,
                            EmployeeId = 2,
                            ProductId = 3,
                            ReportId = 0
                        });
                });

            modelBuilder.Entity("KzStock.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmployeeId");

                    b.Property<bool>("IsPaid");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 5, 20, 12, 2, 24, 186, DateTimeKind.Local).AddTicks(9905),
                            EmployeeId = 1,
                            IsPaid = false
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 4, 23, 12, 2, 24, 187, DateTimeKind.Local).AddTicks(291),
                            EmployeeId = 4,
                            IsPaid = false
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2018, 7, 27, 12, 2, 24, 187, DateTimeKind.Local).AddTicks(296),
                            EmployeeId = 2,
                            IsPaid = true
                        });
                });

            modelBuilder.Entity("KzStock.Models.Purchase", b =>
                {
                    b.HasOne("KzStock.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KzStock.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KzStock.Models.Report")
                        .WithMany("Purchases")
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KzStock.Models.Report", b =>
                {
                    b.HasOne("KzStock.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
