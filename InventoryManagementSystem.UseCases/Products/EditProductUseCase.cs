using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.PluginInterfaces;
using InventoryManagementSystem.UseCases.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.UseCases.Products
{
    public class EditProductUseCase : IEditProductUseCase
    {
        private readonly IProductRepository productRepository;

        public EditProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task ExecuteAsync(Product product)
        {
            await this.productRepository.UpdateProductAsync(product);
        }
    }
}
