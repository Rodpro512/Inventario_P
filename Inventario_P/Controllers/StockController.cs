using Microsoft.AspNetCore.Mvc;
using Inventario_P.Models;

namespace Inventario_P.Controllers
{
    public class StockController : Controller
    {
        private readonly ProductoDB productoDb = new ProductoDB();
        private readonly BitacoraBD bitacoraDb = new BitacoraBD();
        private readonly MovimientoDeProductoDB movimientoDb = new MovimientoDeProductoDB();

        [HttpGet]
        public IActionResult Index()
        {
            return View(new VistaConTablasViewModel());
        }

        [HttpPost]
        public IActionResult Index(string tablaSeleccionada)
        {
            var model = new VistaConTablasViewModel
            {
                tablaSeleccionada = tablaSeleccionada
            };

            switch (tablaSeleccionada)
            {
                case "Producto":
                    model.ProductoData = productoDb.ObtenerProductos();
                    break;
                case "Bitacora":
                    model.BitacoraData = bitacoraDb.ObtenerBitacoras();
                    break;
                case "MovimientoDeProducto":
                    model.MovimientoDeProductoData = movimientoDb.ObtenerMovimientos();
                    break;
            }

            return View(model);
        }
    }
}
