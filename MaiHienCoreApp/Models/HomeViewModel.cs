using System.Collections.Generic;
using MaiHienCoreApp.Application.ViewModels.Blog;
using MaiHienCoreApp.Application.ViewModels.Common;
using MaiHienCoreApp.Application.ViewModels.Product;

namespace MaiHienCoreApp.Models
{
    public class HomeViewModel
    {
        public List<BlogViewModel> LastestBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public List<ProductCategoryViewModel> HomeCategories { set; get; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}