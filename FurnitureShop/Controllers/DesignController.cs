using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
