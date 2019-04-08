using AutoMapper;
using KzStock.Models;
using KzStock.ViewModels;

namespace angular_netcore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}