using AutoMapper.QueryableExtensions;
using MaiHienCoreApp.Application.Interfaces;
using MaiHienCoreApp.Application.ViewModels.Product;
using MaiHienCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MaiHienCoreApp.Application.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x => x.ProductCategory).ProjectTo<ProductViewModel>().ToList();
        }
    }
}