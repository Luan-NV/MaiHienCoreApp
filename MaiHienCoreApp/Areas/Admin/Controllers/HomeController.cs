using MaiHienCoreApp.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace MaiHienCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("UserId");
            return View();
        }
    }
}