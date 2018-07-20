using System;
using System.Collections.Generic;
using System.Text;
using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Data.IRepositories;

namespace MaiHienCoreApp.Data.EF.Repositories
{
    public class BlogTagRepository : EFRepository<BlogTag, int>, IBlogTagRepository
    {
        public BlogTagRepository(AppDbContext context) : base(context)
        {
        }
    }
}