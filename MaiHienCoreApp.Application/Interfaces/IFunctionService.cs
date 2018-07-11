using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MaiHienCoreApp.Application.ViewModels.System;

namespace MaiHienCoreApp.Application.Interfaces
{
    public interface IFunctionService : IDisposable
    {
        Task<List<FunctionViewModel>> GetAll();

        List<FunctionViewModel> GetAllByPermission(Guid userId);
    }
}