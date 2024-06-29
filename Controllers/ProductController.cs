using ASP.NET_MVC_Core_WebApp.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using static ASP.NET_MVC_Core_WebApp.Seeding.ProductsData;

namespace ASP.NET_MVC_Core_WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult All()
        {
            return View(Products);
        }

        public IActionResult ById(string id)
        {
            ProductViewModel? product = Products.FirstOrDefault(p => p.Id.ToString().Equals(id));
            if(product == null)
            {
                return this.RedirectToAction("All");
            }
           return this.View(product);
        }

        public IActionResult AllAsJson()
        {
            string jsonText = JsonConvert.SerializeObject(Products, Formatting.Indented);
            return Json(jsonText);
        }
    }
}
