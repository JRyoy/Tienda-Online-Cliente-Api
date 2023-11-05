using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Carritos;

public interface ICarritoService
{
    List<Carrito>GetCarrito();
}
public class CarritoService:ICarritoService
{
    private readonly AplicacionDBContext context;
    public CarritoService(AplicacionDBContext context)
    {
        this.context = context;
    }
    public List<Carrito>GetCarrito()
    {
        return context.Carritos.ToList();
    }
}
