using AutoMapper;
using MaiHienCoreApp.Application.ViewModels.Product;
using MaiHienCoreApp.Data.Entities;

namespace MaiHienCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}