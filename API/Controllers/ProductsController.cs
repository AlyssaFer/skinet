using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly iProductRepository _repo;

        //consturctor
        public ProductsController(iProductRepository repo)
        {
            _repo = repo;
        }

        //async is used to handel mulitple http requests 
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _repo.GetProductsAsync();

            return Ok(products);
        }

//passing an id as a route parameter to get a single product
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }

//methods to return the brands
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            //because it is and IReadOnlyList
            return Ok(await _repo.GetProductBrandsAsync());
        }

//methods to return the types
         [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            //because it is and IReadOnlyList
            return Ok(await _repo.GetProductTypesAsync());
        }
    }
}