using Varios;

namespace Api.Funcionalidades.Carritos;

public interface ICarritoService
{
    List<Carrito>GetCarrito();
}
public class CarritoService:ICarritoService
{
    List<Carrito>carritos;
    public CarritoService()
    {
        carritos=new List<Carrito>{};
    }
    public List<Carrito>GetCarrito()
    {
        return carritos;
    }
}
