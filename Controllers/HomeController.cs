using ASP.NET_MVC_Core_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET_MVC_Core_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //How to pass data from controller to view
            //1. Using model -> Lerge structured data, usually forms and details pages
            //2. Using ViewBag -> Random data, using dynamic objects
            //3. Using ViewData -> Random data, using dictionary
            ViewBag.Message = "Hello world from ViewBag!";
            ViewData["Msg"] = "Hello world from ViewData!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "This is an ASP.NET Core MVC app.";
            return View();
        }

        public IActionResult Numbers()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NumbersToN(int count = -1)
        {
            ViewData["Count"] = count;

            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
