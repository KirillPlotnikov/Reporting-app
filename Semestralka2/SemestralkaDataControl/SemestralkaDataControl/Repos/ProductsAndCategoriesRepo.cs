using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaDataControl.Repos
{
    public class ProductsAndCategoriesRepo : IProductsAndCategoriesRepo
    {

      
        public readonly ApplicationContext _context;

        protected ApplicationContext Context => _context;
        public ProductsAndCategoriesRepo() : this(new ApplicationContext()) { }
        public ProductsAndCategoriesRepo(ApplicationContext context)
        {
            _context = context;
           
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<List<Category>> GetCategories()
        {
            return await (from c in Context.Categories select c).ToListAsync<Category>();
        }

        public async Task<List<Product>> GetProductsOfCategory(int id)
        {
            return await (from p in Context.Products where p.CategoryId == id select p).ToListAsync<Product>();
        }
    }
}
