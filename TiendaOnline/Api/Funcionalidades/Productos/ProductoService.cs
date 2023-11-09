namespace Api.Funcionalidades.Productos;

using System;
using Api.Persistencia;
using Varios;
public interface IProductoService
{
    void Createproducto(ProductoCommandDto productoDto);
    void Daleteproducto(Guid productoid);
    List<ProductoQueryDto> GetProductos();
    void Updateproducto(Guid productoId, ProductoCommandDto productoDto);
}
public class ProductoService : IProductoService
{
    private readonly AplicacionDbContext context;

    public ProductoService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void Createproducto(ProductoCommandDto productoDto)
    {
        context.Productos.Add(new Producto(productoDto.Nombre, productoDto.Precio, productoDto.Stock));
        context.SaveChanges();
    }

    public void Daleteproducto(Guid productoid)
    {
        var producto = context.Productos.FirstOrDefault(x => x.Id == productoid);
        if (producto != null)
        {
            context.Remove(producto);
            context.SaveChanges();
        }
    }

    public List<ProductoQueryDto> GetProductos()
    {
        return context.Productos.Select(x => new ProductoQueryDto { Id = x.Id, Nombre = x.Nombre, Precio = x.Precio, Stock = x.Stock }).ToList();
    }

    public void Updateproducto(Guid productoid, ProductoCommandDto productoDto)
    {
        var producto = context.Productos.FirstOrDefault(x => x.Id == productoid);
        if (producto != null)
        {
            producto.Nombre = productoDto.Nombre;
            producto.Precio = producto.Precio;
            producto.Stock = producto.Stock;
            context.SaveChanges();
        }

    }
}

