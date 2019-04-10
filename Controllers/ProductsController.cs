using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using KzStock.Core;
using KzStock.Models;
using KzStock.Persistance;
using KzStock.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KzStock.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IGeneric<Product> productRepo;

        public ProductsController(IUnitOfWork unitOfWork, IMapper mapper, IGeneric<Product> productRepo)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.productRepo = productRepo;
        }

        [HttpGet("api/GetProducts")]
        public List<ProductViewModel> GetProducts()
        {
            var modelList =  productRepo.SelectAll();
            return mapper.Map<IEnumerable<Product>, List<ProductViewModel>>(modelList);
        }
    }
}