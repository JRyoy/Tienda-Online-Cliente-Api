using Api.Funcionalidades.ItemCarritos;
using Api.Funcionalidades.Productos;
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
        var itemCarrito = context.ItemCarritos.FirstOrDefault(x => x.IdItemCarrito == itemcarritoid);
        if (carrito != null && itemCarrito != null)
        {
            carrito.AgregarProductos(itemCarrito.Producto, itemCarrito.Cantidad);
        }
    }

    public void CreateCarrito(CarritoCommandDto carritoDto)
    {
        context.Carritos.Add(new Carrito(carritoDto.IdCliente));
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
        var itemCarrito = carrito.Productos.FirstOrDefault(x => x.IdItemCarrito == itemcarritoid);
        if (carrito != null && itemCarrito != null)
        {
            carrito.Productos.Remove(itemCarrito);
            context.SaveChanges();
        }
    }

    public List<CarritoQueryDto> GetCarrito()
    {
        var response = context.Carritos.Include(x => x.Productos).ThenInclude(x => x.Producto)
        .Select( x=>new CarritoQueryDto
        {
            Id=x.Id,
            IdCliente=x.IdCliente,
            Total=x.Total,
            Productos = x.Productos.Select(y => new ItemCarritoQueryDto { IdItemCarrito=y.IdItemCarrito,Cantidad = y.Cantidad, Producto = new ProductoQueryDto { Id = y.Producto.Id, Nombre = y.Producto.Nombre} }).ToList()
        }).ToList();

        return response;
    }

    public void UpdateCarrito(Guid carritoid, CarritoCommandDto carritoDto)
    {
        var carrito = context.Carritos.FirstOrDefault(x => x.Id == carritoid);
        if (carrito != null)
        {
            carrito.IdCliente = carritoDto.IdCliente;
        }
    }
}
