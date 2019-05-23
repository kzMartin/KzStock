using System;
using System.Collections.Generic;
using KzStock.Models;
using Microsoft.EntityFrameworkCore;

namespace KzStock.Persistance
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Galletas Oreo", UnitPrice = 50, Stock = 10 },
                new Product { Id = 2, Name = "Coca Cola", UnitPrice = 35, Stock = 8 },
                new Product { Id = 3, Name = "Agua Helada", UnitPrice = 45, Stock = 15 },
                new Product { Id = 4, Name = "Jugo Ades", UnitPrice = 22, Stock = 3 },
                new Product { Id = 5, Name = "Helado Palito", UnitPrice = 12, Stock = 5 }
            );

            builder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Martin", LastName = "Mato", Email = "martin@kzsoftworks.com", Enabled = true },
                new Employee { Id = 2, Name = "James", LastName = "Bond", Email = "james@kzsoftworks.com", Enabled = true },
                new Employee { Id = 3, Name = "Fulano", LastName = "Detal", Email = "fulano@kzsoftworks.com", Enabled = true },
                new Employee { Id = 4, Name = "Victor", LastName = "Pons", Email = "victor@kzsoftworks.com", Enabled = true }
            );

            builder.Entity<Purchase>().HasData(
                new Purchase { Amount = 1, EmployeeId = 1, Id = 1, ProductId = 1},
                new Purchase { Amount = 1000, EmployeeId = 1, Id = 2, ProductId = 2},
                new Purchase { Amount = 3, EmployeeId = 1, Id = 3, ProductId = 3},
                new Purchase { Amount = 1, EmployeeId = 4, Id = 4, ProductId = 3},
                new Purchase { Amount = 1000, EmployeeId = 4, Id = 5, ProductId = 2},
                new Purchase { Amount = 3, EmployeeId = 4, Id = 6, ProductId = 4},
                new Purchase { Amount = 1, EmployeeId = 2, Id = 7,ProductId = 2},
                new Purchase { Amount = 1000, EmployeeId = 2, Id = 8, ProductId = 1},
                new Purchase { Amount = 3, EmployeeId = 2, Id = 9, ProductId = 3}
            );

            builder.Entity<Report>().HasData(
                new Report
                {
                    Id = 1,
                    Date = DateTime.Now.AddDays(-3),
                    EmployeeId = 1,
                    IsPaid = false,
                }, new Report
                {
                    Id = 2,
                    Date = DateTime.Now.AddDays(-30),
                    EmployeeId = 4,
                    IsPaid = false,
                }, new Report
                {
                    Id = 3,
                    Date = DateTime.Now.AddDays(-300),
                    EmployeeId = 2,
                    IsPaid = true,
                }
            );

        }
    }
}