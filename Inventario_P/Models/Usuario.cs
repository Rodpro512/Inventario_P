using System;
using System.Collections.Generic;

namespace Inventario_P.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contraseña { get; set; }

    public virtual ICollection<Bitacora> Bitacoras { get; set; } = new List<Bitacora>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<MovimientoDeProducto> MovimientoDeProductos { get; set; } = new List<MovimientoDeProducto>();
}
