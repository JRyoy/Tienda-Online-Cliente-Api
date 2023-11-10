using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Varios;

namespace Api.Funcionalidades.Carritos;

public interface ICarritoService
{
    void AddItemcarrito(Guid carritoid, Guid itemcarritoid);
    void CreateCarrito(CarritoCommandDto carritoDto);
    void DeleteCarrito(Guid carritoid);
    void DeleteItemCarrito(Guid carritoid, Guid itemcarritoid);
    List<CarritoQueryDto> GetCarrito();
    void UpdateCarrito(Guid carritoid, CarritoCommandDto carritoDto);
}
public class CarritoService : ICarritoService
{
    private readonly AplicacionDbContext context;
    public CarritoService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void AddItemcarrito(Guid carritoid, Guid itemcarritoid)
    {
        var carrito = context.Carritos.FirstOrDefault(x => x.Id == carritoid);
        var itemCarrito = context.ItemCarritos.FirstOrDefault(x => x.Id == itemcarritoid);
        if (carrito != null && itemCarrito != null)
        {
            carrito.AgregarProductos(itemCarrito.Producto, itemCarrito.Cantidad);
        }
    }

    public void CreateCarrito(CarritoCommandDto carritoDto)
    {
        context.Carritos.Add(new Carrito(carritoDto.Cliente));
        context.SaveChanges();
    }

    public void DeleteCarrito(Guid carritoid)
    {
        var carrito = context.Carritos.FirstOrDefault(x => x.Id == carritoid);
        if (carrito != null)
        {
            context.Remove(carrito);
            context.SaveChanges();
        }
    }

    public void DeleteItemCarrito(Guid carritoid, Guid itemcarritoid)
    {
       var carrito = context.Carritos.Where(x => x.Id == carritoid).Include(x=>x.Productos).First();
        var itemCarrito = carrito.Productos.FirstOrDefault(x => x.Id == itemcarritoid);
         if (carrito != null && itemCarrito != null)
        {
            carrito.Productos.Remove(itemCarrito);
            context.SaveChanges();
        }
    }

    public List<CarritoQueryDto> GetCarrito()
    {
        return context.Carritos.Include(x=>x.Productos)
        .Select( x=>new CarritoQueryDto
        {
            Id=x.Id,
            Cliente=x.Cliente,
            Total=x.Total,
            Productos=x.Productos.Select(y=> new ItemCarrito {Id=y.Id,Producto=y.Producto,Cantidad=y.Cantidad,Subtotal=y.Subtotal}).ToList()
        }).ToList();

    }

    public void UpdateCarrito(Guid carritoid, CarritoCommandDto carritoDto)
    {
        var carrito = context.Carritos.FirstOrDefault(x => x.Id == carritoid);
        if (carrito != null)
        {
            carrito.Cliente = carritoDto.Cliente;
        }
    }
}
