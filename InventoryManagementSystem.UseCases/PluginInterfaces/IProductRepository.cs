using InventoryManagementSystem.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);

        Task<Product?> GetProductByIdAsync(int productId);
    }
}
