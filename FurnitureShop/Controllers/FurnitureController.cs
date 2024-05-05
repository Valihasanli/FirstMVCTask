using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class FurnitureController : Controller
    {
        private List<Furniture> CreateFurnitureList()
        {
            var furnitureList = new List<Furniture>();
            Furniture furniture1 = new Furniture
            {
                Name = "Divan",
                Id = 1,
                Price=123
            };
            Furniture furniture2 = new Furniture
            {
                Name = "Stol",
                Id = 2,
                Price = 423
            };
            Furniture furniture3 = new Furniture
            {
                Name = "Stul",
                Id = 3,
                Price = 50
            };
            furnitureList.Add(furniture1);
            furnitureList.Add (furniture2);
            furnitureList.Add(furniture3);
            return furnitureList;
        }
        public ActionResult OurDesign()
        {
            var furnitureList = CreateFurnitureList();

            ViewBag.FurnitureList = furnitureList;

            return View();
        }
    }
}
