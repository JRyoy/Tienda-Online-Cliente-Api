using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Carritos;

public interface ICarritoService
{
    List<Carrito>GetCarrito();
}
public class CarritoService:ICarritoService
{
    private readonly AplicacionDbContext context;
    public CarritoService(AplicacionDbContext context)
    {
        this.context = context;
    }
    public List<Carrito>GetCarrito()
    {
        return context.Carritos.ToList();
    }
}
