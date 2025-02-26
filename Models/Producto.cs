using System;
using System.Collections.Generic;

namespace crud_ASP.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? NombreProducto { get; set; }

    public string? Sku { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public int IdCategoria { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
}
