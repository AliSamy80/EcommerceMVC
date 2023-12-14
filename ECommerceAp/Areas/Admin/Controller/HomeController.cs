using Microsoft.AspNetCore.Mvc;

namespace ECommerceAp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
