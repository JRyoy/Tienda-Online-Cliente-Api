using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Carritos;

public interface ICarritoService
{
    void AddItemcarrito(Guid carritoid, Guid itemcarritoid);
    void CreateCarrito(CarritoDto carritoDto);
    void DeleteCarrito(Guid carritoid);
    List<Carrito>GetCarrito();
    void UpdateCarrito(Guid carritoid, CarritoDto carritoDto);
}
public class CarritoService:ICarritoService
{
    private readonly AplicacionDbContext context;
    public CarritoService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void AddItemcarrito(Guid carritoid, Guid itemcarritoid)
    {
        var carrito=context.Carritos.FirstOrDefault(x=>x.Id==carritoid);
        var itemCarrito=context.ItemCarritos.FirstOrDefault(x=>x.Id ==itemcarritoid);
        if(carrito !=null&&itemCarrito!=null)
       {
            carrito.AgregarProductos(itemCarrito.Producto,itemCarrito.Cantidad);
       }
    }

    public void CreateCarrito(CarritoDto carritoDto)
    {
        context.Carritos.Add(new Carrito(carritoDto.Cliente));
        context.SaveChanges();
    }

    public void DeleteCarrito(Guid carritoid)
    {
        var carrito=context.Carritos.FirstOrDefault(x=>x.Id==carritoid);
       if(carrito !=null)
       {
            context.Remove(carrito);
            context.SaveChanges();
       }
    }

    public List<Carrito>GetCarrito()
    {
        return context.Carritos.ToList();
    }

    public void UpdateCarrito(Guid carritoid, CarritoDto carritoDto)
    {
       var carrito=context.Carritos.FirstOrDefault(x=>x.Id==carritoid);
       if(carrito !=null)
       {
        carrito.Cliente=carritoDto.Cliente;
       }
    }
}
