using System;
using System.Collections.Generic;

namespace Inventario_P.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Teléfono { get; set; }

    public string? Cargo { get; set; }

    public int? Carnet { get; set; }

    public string? Dirreccion { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
