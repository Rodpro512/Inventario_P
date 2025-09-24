using Microsoft.AspNetCore.Mvc;
using Inventario_P.Models;

namespace Inventario_P.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new VistaConTablasViewModel());
        }

        [HttpPost]
        public IActionResult Index(VistaConTablasViewModel model)
        {
            // Carga los datos según la tabla seleccionada
            switch (model.tablaSeleccionada)
            {
                case "Producto":
                    model.ProductoData = new ProductoDB().ObtenerProductos();
                    break;

                case "Bitacora":
                    model.BitacoraData = new BitacoraBD().ObtenerBitacoras();
                    break;

                case "MovimientoDeProducto":
                    model.MovimientoDeProductoData = new MovimientoDeProductoDB().ObtenerMovimientos();
                    break;
            }

            return View(model);
        }
    }
}
