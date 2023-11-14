using Varios;

namespace Api.Funcionalidades.Carritos;

public class CarritoCommandDto
{
    public required Cliente Cliente { get; set; }
    public required double Total { get; set; }
}
public class CarritoQueryDto
{
    public Guid Id { get; set; }
    public Cliente Cliente { get; set; } 
    public double Total { get; set; }
    public List<ItemCarrito> Productos { get; set; } = new List<ItemCarrito>();
}