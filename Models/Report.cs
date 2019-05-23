using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KzStock.Models
{
    public class Report
    {
        public int Id { get; set; }
        public bool IsPaid { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public IEnumerable<Purchase> Purchases { get; set; }
        public DateTime Date { get; set; }

        public Report()
        {
            Date = DateTime.Now;
            IsPaid = false;
        }
    }
}
