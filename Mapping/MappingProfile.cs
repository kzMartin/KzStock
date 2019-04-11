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
        }
    }
}