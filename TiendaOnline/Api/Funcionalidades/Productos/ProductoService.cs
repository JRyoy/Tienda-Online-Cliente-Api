namespace Api.Funcionalidades.Productos;

using Api.Persistencia;
using Varios;
public interface IProductoService
{
    List<Producto> GetProductos();
}
public class ProductoService : IProductoService
{   
      private readonly AplicacionDBContext context;

    public ProductoService(AplicacionDBContext context)
    {
        this.context = context;
    }

    public List<Producto> GetProductos()
    {
        return context.Productos.ToList();
    }
}

