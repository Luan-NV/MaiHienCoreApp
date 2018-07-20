using System;
using System.Collections.Generic;
using System.Text;
using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Data.IRepositories;

namespace MaiHienCoreApp.Data.EF.Repositories
{
    public class WholePriceRepository : EFRepository<WholePrice, int>, IWholePriceRepository
    {
        public WholePriceRepository(AppDbContext context) : base(context)
        {
        }
    }
}