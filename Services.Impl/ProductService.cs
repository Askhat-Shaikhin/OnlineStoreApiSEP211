﻿using OnlineStore.Model;
using OnlineStore.Repo.Interfaces;
using Services.Interfaces;

namespace Services.Impl
{
    public class ProductService : IProductInterface
    {
        //private readonly IProductRepository _productRepository;

        //public ProductService(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}


        public async Task<Product> GetProduct()
        {
            return new Product()
            {
                Id = 1,
                Name = "product 1",
                Price = 100,
                Description = "new laptop with best price"
            };
        }

        public async Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
            //return await _productRepository.GetProducts();
        }
    }
}
