namespace Varios;

public class Plataforma
{
    List<Clientes> Cuentas{get; set;}
    List<Producto> productos{get; set;}
    List<Vendedor> Vendedores{get; set;}
   
    public Plataforma()
    {
        this.Cuentas=new List<Clientes>();
        this.productos=new List<Producto>();
        this.Vendedores=new List<Vendedor>();
       
    }
    
    public void AgregarCuenta(Clientes Cuenta)=>Cuentas.Add(Cuenta);
    
    public void AgregarVendedor(Vendedor vendedor)=>Vendedores.Add(vendedor);
    
    
     public void AgregarProductoAVendedor(Guid vendedorId, Producto producto)
    {
        var vendedor = Vendedores.FirstOrDefault(v => v.Id == vendedorId);
        if (vendedor != null)
        {
            vendedor.AgregarProductos(producto);
        }
    }
        public List<Producto> BuscarProductosPorTextoLibre(string textoBusqueda)
{
    List<Producto> productosEncontrados = new List<Producto>();

    foreach (var vendedor in Vendedores)
    {
        foreach (var producto in vendedor.Productos)
        {
            if (producto.Nombre.Contains(textoBusqueda) ||
                producto.Descripcion.Contains(textoBusqueda) ||
                producto.Categoria.Contains(textoBusqueda))
            {
                productosEncontrados.Add(producto);
            }
        }
    }

    return productosEncontrados;
}

    public void FiltrarMenor()
    {
        var productosOrdenados = productos.OrderBy(x => x.Precio);
       foreach (var producto in productosOrdenados)
    {
        Console.WriteLine($"{producto.Id}, {producto.Nombre}, ${producto.Precio}");
    }
    }
    
    
    public void FiltrarMayor()
    {
        var productosOrdenados = productos.OrderByDescending(x => x.Precio);
       foreach (var producto in productosOrdenados)
    {
        Console.WriteLine($"{producto.Id}, {producto.Nombre}, ${producto.Precio}");
    }

}}
