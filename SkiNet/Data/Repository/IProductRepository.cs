using SkiNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiNet.Data.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetProducByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
