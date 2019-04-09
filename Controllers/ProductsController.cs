using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using KzStock.Models;
using KzStock.Persistance;
using KzStock.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KzStock.Controllers
{
    public class ProductsController : Controller
    {
        private readonly StockDbContext dbContext;
        private readonly IMapper mapper;
        public ProductsController(StockDbContext dbContext, IMapper mapper)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        [HttpGet("api/GetProducts")]
        public async Task<List<ProductViewModel>> GetProducts()
        {
            var modelList = await dbContext.Products.ToListAsync();
            return mapper.Map<List<Product>, List<ProductViewModel>>(modelList);
        }
    }
}