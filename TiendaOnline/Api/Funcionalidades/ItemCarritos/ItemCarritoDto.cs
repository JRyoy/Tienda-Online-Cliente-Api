using Api.Funcionalidades.Productos;
using Varios;

namespace Api.Funcionalidades.ItemCarritos;

public class ItemCarritoDto
{
    public required ProductoDto productoDto { get; set; }
    public required int Cantidad { get; set; }
    public ItemCarritoDto(ProductoDto productoDto,int Cantidad)
    {
        this.productoDto=productoDto;
        this.Cantidad=Cantidad;
    }

}
