using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appDash.Models;
using Microsoft.AspNetCore.Authorization; // Asegúrate de que esta importación esté presente

namespace appDash.Controllers
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
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

            public IActionResult Dashboard()
        {
            Console.WriteLine("Hola");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
