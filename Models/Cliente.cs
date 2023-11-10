using System;
using System.Collections.Generic;

namespace Inyeccion_Dependencias.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }
}
