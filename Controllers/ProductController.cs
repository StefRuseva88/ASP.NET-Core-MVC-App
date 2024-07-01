using ASP.NET_MVC_Core_WebApp.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using static ASP.NET_MVC_Core_WebApp.Seeding.ProductsData;

namespace ASP.NET_MVC_Core_WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult All()
        {
            return View(Products);
        }

        [Route("/Product/Details/{id}")]
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

        public IActionResult DownloadProductsInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var product in Products)
            {
                stringBuilder.AppendLine($"Product with Id: {product.Id}");
                stringBuilder.AppendLine($"## Product Name: {product.Name}");
                stringBuilder.AppendLine($"## Price: {product.Price:f2}$");
                stringBuilder.AppendLine($"-------------------------------");
            }

            Response.Headers.Add(HeaderNames.ContentDisposition, "attachment;filename=products.txt");
            Response.Headers.Add(HeaderNames.ContentType, "text/plain");
            return File(Encoding.UTF8.GetBytes(stringBuilder.ToString()),"text/plain"); 
        }
    }
}
