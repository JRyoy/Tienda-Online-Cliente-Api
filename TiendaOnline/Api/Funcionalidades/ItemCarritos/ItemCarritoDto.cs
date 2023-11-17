using Api.Funcionalidades.Productos;
using Varios;

namespace Api.Funcionalidades.ItemCarritos;

public class ItemCarritoCommandDto
{
    public Guid IdProducto { get; set; }
    public int Cantidad { get; set; }
}
public class ItemCarritoQueryDto
{
    public required ProductoQueryDto Producto { get; set; }
    public int Cantidad { get; set; }
}
