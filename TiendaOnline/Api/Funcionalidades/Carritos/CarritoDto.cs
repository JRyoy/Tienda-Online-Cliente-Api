using Varios;

namespace Api.Funcionalidades.Carritos;

public class CarritoDto
{
    public required Cliente Cliente { get; set; }
    public required double Total { get; set; }
}
