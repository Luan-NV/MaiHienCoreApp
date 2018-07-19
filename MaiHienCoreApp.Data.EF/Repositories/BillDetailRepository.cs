using System;
using System.Collections.Generic;
using System.Text;
using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Data.IRepositories;

namespace MaiHienCoreApp.Data.EF.Repositories
{
    public class BillDetailRepository : EFRepository<BillDetail, int>, IBillDetailRepository
    {
        public BillDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}