using Microsoft.AspNetCore.Mvc;

namespace ECommerceAp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        public IActionResult Myslider()
        {
            return View();
        }
    }
}
