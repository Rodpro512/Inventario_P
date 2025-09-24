using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Inventario_P.Models;

public class VistaConTablasViewModel
{
    public string tablaSeleccionada { get; set; }
    public List<Producto> ProductoData { get; set; }
    public List<Bitacora> BitacoraData { get; set; }
    public List<MovimientoDeProducto> MovimientoDeProductoData { get; set; }

    
}
