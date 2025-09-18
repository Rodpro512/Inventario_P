using Microsoft.AspNetCore.Mvc;

namespace Inventario_P.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
