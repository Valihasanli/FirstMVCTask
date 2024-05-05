using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
