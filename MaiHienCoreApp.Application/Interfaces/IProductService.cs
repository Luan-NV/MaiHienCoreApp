using MaiHienCoreApp.Application.ViewModels.Product;
using MaiHienCoreApp.Utilities.Dtos;
using System;
using System.Collections.Generic;

namespace MaiHienCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}