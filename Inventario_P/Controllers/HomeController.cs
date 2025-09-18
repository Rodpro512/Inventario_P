using System.Diagnostics;
using Inventario_P.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventario_P.Controllers
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
            return View();
        }
    }
}
