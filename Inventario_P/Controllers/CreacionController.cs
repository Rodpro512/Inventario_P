using Microsoft.AspNetCore.Mvc;

namespace Inventario_P.Controllers
{
    public class CreacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
