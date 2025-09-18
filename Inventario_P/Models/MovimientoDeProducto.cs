using System;
using System.Collections.Generic;

namespace Inventario_P.Models;

public partial class MovimientoDeProducto
{
    public int IdMoviento { get; set; }

    public int? IdProducto { get; set; }

    public int? IdUsuario { get; set; }

    public int? Cantidad { get; set; }

    public DateOnly? Fecha { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
