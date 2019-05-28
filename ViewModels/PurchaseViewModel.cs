namespace KzStock.ViewModels
{
    public class PurchaseViewModel
    {
        public EmployeeViewModel Employee { get; set; }
        public int Id { get; set; }
        public ProductViewModel Product { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; } 
    }
}
