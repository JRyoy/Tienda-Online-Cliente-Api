using Api.Funcionalidades.ItemCarritos;
using Varios;

namespace Api.Funcionalidades.Carritos;

public class CarritoCommandDto
{
    public Guid IdCliente { get; set; }
    public required double Total { get; set; }
}
public class CarritoQueryDto
{
    public Guid Id { get; set; }
    public Guid IdCliente { get; set; }
    public double Total { get; set; }
    public List<ItemCarritoDto> Productos { get; set; } = new List<ItemCarritoDto>();
}