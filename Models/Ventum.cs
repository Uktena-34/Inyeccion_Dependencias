using System;
using System.Collections.Generic;

namespace Inyeccion_Dependencias.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Ganancia { get; set; }
}
