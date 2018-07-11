using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Infrastructure.Interfaces;

namespace MaiHienCoreApp.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}