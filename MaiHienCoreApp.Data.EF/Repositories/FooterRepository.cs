using System;
using System.Collections.Generic;
using System.Text;
using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Data.IRepositories;

namespace MaiHienCoreApp.Data.EF.Repositories
{
    public class FooterRepository : EFRepository<Footer, string>, IFooterRepository
    {
        public FooterRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}