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
                new Employee { Id = 3, Name = "Fulano", LastName = "Detal", Email = "fulano@kzsoftworks.com", Enabled = true }
            );
        }
    }
}