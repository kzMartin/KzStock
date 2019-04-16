﻿// <auto-generated />
using KzStock.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KzStock.Migrations
{
    [DbContext(typeof(StockDbContext))]
    [Migration("20190411131408_UpdateProductsData")]
    partial class UpdateProductsData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}