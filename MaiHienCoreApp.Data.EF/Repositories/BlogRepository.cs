using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Data.Enums;
using MaiHienCoreApp.Data.IRepositories;

namespace MaiHienCoreApp.Data.EF.Repositories
{
    public class BlogRepository : EFRepository<Blog, int>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}