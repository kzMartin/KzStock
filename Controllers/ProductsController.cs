using System.Collections.Generic;
using AutoMapper;
using KzStock.Core;
using KzStock.Models;
using KzStock.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KzStock.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGeneric<Product> _productRepo;
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork, IMapper mapper, IGeneric<Product> productRepo)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepo = productRepo;
        }

        [HttpGet("api/GetProducts")]
        public List<ProductViewModel> GetProducts()
        {
            var modelList = _productRepo.SelectAll();
            return _mapper.Map<IEnumerable<Product>, List<ProductViewModel>>(modelList);
        }
    }
}