namespace Api.Funcionalidades.Productos;
using Varios;
public interface IProductoService
{
    List<Producto> GetProductos();
}
public  class ProductoService:IProductoService
{
    List<Producto>productos;
    public ProductoService()
    {
        productos=new List<Producto>
        {
           
        };
    }
    public List<Producto> GetProductos()
    {
        return productos;
    }
}

