using System;
using System.Collections.Generic;

namespace crud_ASP.Models;

public partial class TableEmpleado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Avatar { get; set; }
}
