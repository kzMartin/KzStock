using System.Linq;
using System.Xml.XPath;
using AutoMapper;
using KzStock.Models;
using KzStock.ViewModels;

namespace KzStock.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<Report, ReportViewModel>();
            CreateMap<Purchase, PurchaseViewModel>();

        }
    }
}