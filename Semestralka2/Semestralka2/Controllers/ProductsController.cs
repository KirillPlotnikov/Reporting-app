using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repos;

namespace Semestralka2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsAndCategoriesRepo _repo;

        public ProductsController(IProductsAndCategoriesRepo repo)
        {
            _repo = repo;

        }

        //GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var result = await _repo.GetCategories();
            return result;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(int id)
        {
            var products = await _repo.GetProductsOfCategory(id);

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }
    }
}
