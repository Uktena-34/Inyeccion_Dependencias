using System;
using System.Collections.Generic;

namespace Inyeccion_Dependencias.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string TipoProducto { get; set; } = null!;

    public int? Inventario { get; set; }
}
