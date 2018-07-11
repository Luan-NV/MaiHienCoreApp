using MaiHienCoreApp.Application.ViewModels.Product;
using System;
using System.Collections.Generic;

namespace MaiHienCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}