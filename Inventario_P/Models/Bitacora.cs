using System;
using System.Collections.Generic;

namespace Inventario_P.Models;

public partial class Bitacora
{
    public int IdLogin { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Accion { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
