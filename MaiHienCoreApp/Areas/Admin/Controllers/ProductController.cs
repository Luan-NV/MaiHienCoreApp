using MaiHienCoreApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MaiHienCoreApp.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region AJAX API

        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productService.GetAll();
            return new OkObjectResult(model);
        }

        #endregion AJAX API
    }
}