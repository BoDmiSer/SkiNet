using Microsoft.EntityFrameworkCore;
using SkiNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiNet.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;

        }
        public async Task<Product> GetProducByIdAsync(int id)
        {
           return await _context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
