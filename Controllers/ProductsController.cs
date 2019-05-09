using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KzStock.Core;
using KzStock.Models;
using KzStock.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KzStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Product> _productRepo;

        public ProductsController(IMapper mapper, IGenericRepository<Product> productRepo)
        {
            _mapper = mapper;
            _productRepo = productRepo;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            var products = await _productRepo.FindAllAsync();
            return Ok(_mapper.Map<IEnumerable<Product>, List<ProductViewModel>>(products));
        }

        [HttpGet("get/{id?}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productRepo.FindByConditionAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Product, ProductViewModel>(product.SingleOrDefault()));
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] ProductViewModel product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            var newProduct = _mapper.Map<ProductViewModel, Product>(product);
            _productRepo.Create(newProduct);
            await _productRepo.SaveAsync();


            return CreatedAtAction("Create", new { id = newProduct.Id }, _mapper.Map<Product, ProductViewModel>(newProduct));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] ProductViewModel product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            var previousProduct = _mapper.Map<ProductViewModel, Product>(product);
            _productRepo.Update(previousProduct);
            await _productRepo.SaveAsync();

            return NoContent();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productRepo.FindByConditionAsync(p => p.Id == id);
            if (product == null)
            {
                return BadRequest();
            }

            _productRepo.Delete(product.SingleOrDefault());
            await _productRepo.SaveAsync();

            return NoContent();
        }
    }
}