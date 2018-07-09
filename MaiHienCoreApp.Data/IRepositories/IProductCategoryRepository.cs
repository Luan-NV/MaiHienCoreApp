using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace MaiHienCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}