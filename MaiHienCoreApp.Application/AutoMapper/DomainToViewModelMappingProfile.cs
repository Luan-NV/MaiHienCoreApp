using AutoMapper;
using MaiHienCoreApp.Application.ViewModels.Product;
using MaiHienCoreApp.Application.ViewModels.System;
using MaiHienCoreApp.Data.Entities;

namespace MaiHienCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
        }
    }
}