using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Diagnostics;

namespace SalesWebMvc.Controllers
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
            ViewData["SubTitle"] = "Page subtitle";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Salles web MVC App from C# Course";
            ViewData["Professor"] = "Nélio Alves Falando";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
