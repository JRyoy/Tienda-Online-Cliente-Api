using Varios;

namespace Api.Funcionalidades.ItemCarritos;

public class ItemCarritoDto
{

    public required Producto Producto { get; set; }

    public required int Cantidad { get; set; }

}
