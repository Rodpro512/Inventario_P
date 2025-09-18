using System;
using System.Collections.Generic;

namespace Inventario_P.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public int? Codigo { get; set; }

    public int? IdMarca { get; set; }

    public int? IdCategoria { get; set; }

    public int? Cantidad { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Foto { get; set; }

    public virtual Categorium? IdCategoriaNavigation { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }

    public virtual ICollection<MovimientoDeProducto> MovimientoDeProductos { get; set; } = new List<MovimientoDeProducto>();
}
