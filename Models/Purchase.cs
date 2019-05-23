using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KzStock.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int EmployeeId { get; set; } 
        public Employee Employee { get; set; }
        public double TotalPrice => Product.UnitPrice * Amount;
        public int Amount { get; set; }

        public Purchase(int amount=0)
        {
            Amount = amount;
        }
    }
}