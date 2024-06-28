using Microsoft.AspNetCore.Mvc;

using static ASP.NET_MVC_Core_WebApp.Seeding.ProductsData;

namespace ASP.NET_MVC_Core_WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult All()
        {
            return View(Products);
        }
    }
}
