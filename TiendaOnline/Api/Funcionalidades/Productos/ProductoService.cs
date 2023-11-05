namespace Api.Funcionalidades.Productos;

using Api.Persistencia;
using Varios;
public interface IProductoService
{
    void Createproducto(ProductoDto productoDto);
    List<Producto> GetProductos();
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
        
    }

    public List<Producto> GetProductos()
    {

        return context.Productos.ToList();
    }
}

