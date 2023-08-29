﻿using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.UseCases.Products.Interfaces
{
    public interface IViewProductsByNameUseCase
    {
        Task<IEnumerable<Product>> ExecuteAsync(string name = "");
    }
}
