using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaDataControl.Repos
{
    public interface IProductsAndCategoriesRepo : IDisposable
    {
        Task<List<Category>> GetCategories();
        Task<List<Product>> GetProductsOfCategory(int id);
    }
}
