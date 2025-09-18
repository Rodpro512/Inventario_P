using Microsoft.AspNetCore.Mvc;

namespace Inventario_P.Controllers
{
    public class InformativoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
