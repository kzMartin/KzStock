using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KzStock.ViewModels
{
    public class ReportViewModel
    {
        public bool IsPaid { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public int Id { get; set; }
        public IEnumerable<int> Purchases { get; set; }
        public DateTime Date { get; set; }

        public ReportViewModel()
        {
            Purchases = new List<int> { };
        }

    }
}
