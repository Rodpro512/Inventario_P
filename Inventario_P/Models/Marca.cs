using System;
using System.Collections.Generic;

namespace Inventario_P.Models;

public partial class Marca
{
    public int IdMarca { get; set; }

    public string? NombreMarca { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
