using System;
using System.Collections.Generic;
using System.Text;
using MaiHienCoreApp.Data.Entities;
using MaiHienCoreApp.Infrastructure.Interfaces;

namespace MaiHienCoreApp.Data.IRepositories
{
    public interface IPermissionRepository : IRepository<Permission, int>
    {
    }
}