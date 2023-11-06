namespace Api.Funcionalidades.Productos;

using System;
using Api.Persistencia;
using Varios;
public interface IProductoService
{
    void Createproducto(ProductoDto productoDto);
    void Daleteproducto(Guid productoid);
    List<Producto> GetProductos();
    void Updateproducto(Guid productoId, ProductoDto productoDto);
}
public class ProductoService : IProductoService
{   
      private readonly AplicacionDbContext context;

    public ProductoService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void Createproducto(ProductoDto productoDto)
    {
        context.Productos.Add(new Producto(productoDto.Nombre,productoDto.Precio,productoDto.Stock));
        context.SaveChanges();
    }

    public void Daleteproducto(Guid productoid)
    {
        var producto = context.Productos.FirstOrDefault(x => x.Id ==productoid);
        if(producto !=null)
        {
            context.Remove(producto);
            context.SaveChanges();
        }
    }

    public List<Producto> GetProductos()
    {

        return context.Productos.ToList();
    }

    public void Updateproducto(Guid productoid, ProductoDto productoDto)
    {
        var producto = context.Productos.FirstOrDefault(x => x.Id ==productoid);
        if(producto !=null)
        {
            producto.Nombre=productoDto.Nombre;
            producto.Precio=producto.Precio;
            producto.Stock=producto.Stock;
            context.SaveChanges();
        }
    
    }
}

