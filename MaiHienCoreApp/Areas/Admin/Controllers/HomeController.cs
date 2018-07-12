using MaiHienCoreApp.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace MaiHienCoreApp.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }
    }
}