namespace Varios;

public class Plataforma
{
    public string textoBusqueda { get; set; }
    public int FiltMayor { get; set; }
    public int FiltMenor { get; set; }
    public List<Cliente> Cuentas { get; set; }
    public List<Producto> Productos { get; set; }
    public List<Vendedor> Vendedores { get; set; }
    public List<Producto> ProductosEncontrados { get; set; }
    public List<Categoria> Categorias { get; set; }

    public Plataforma(string textoBusqueda, int FiltMayor, int FiltMenor)
    {
        Validacion.ValidacionCadena(textoBusqueda, "error de busqueda");
        this.textoBusqueda = textoBusqueda;
        Validacion.ValidacionValor(FiltMayor, "El filtro tiene que ser mayor a 0");
        this.FiltMayor = FiltMayor;
        Validacion.ValidacionValor(FiltMenor, "El filtro tiene que ser mayor a 0");
        this.FiltMenor = FiltMenor;
        this.Cuentas = new List<Cliente>();
        this.Productos = new List<Producto>();
        this.Vendedores = new List<Vendedor>();
        this.ProductosEncontrados = new List<Producto>();
        this.Categorias = new List<Categoria>();

    }
    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public void AgregarCuenta(Cliente Cuenta)
    {
        if (Cuentas.Any(cliente => cliente.Email == Cuenta.Email))
        {
            throw new Exception("Error: Correo electrónico ya utilizado");
        }
        //.Any(...) es un método de extensión en C# que se utiliza para determinar 
        //si algún elemento en una secuencia cumple con una condición específica.
        Validacion.ValidarEmail(Cuenta.Email, "Tiene que contener @gmail.com o @hotmail.com");
        Cuentas.Add(Cuenta);

    }

    public void AgregarVendedor(Vendedor vendedor)
    {
        if (Vendedores.Any(vendedor => vendedor.Email == vendedor.Email))
        {
            throw new Exception("Error: Correo electrónico ya utilizado");
        }
        Validacion.ValidarEmail(vendedor.Email, "Tiene que contener @gmail.com o @hotmail.com");
        Vendedores.Add(vendedor);


    }

    public void AgregarProductoAVendedor(Guid vendedorId, Producto producto)
    {
        var vendedor = Vendedores.FirstOrDefault(v => v.Id == vendedorId);
        if (vendedor != null)
        {
            vendedor.AgregarProductos(producto);
        }
    }
    public List<Producto> BuscarProductosPorTextoLibre(double FiltMayor, double FiltMenor)
    {
        foreach (var vendedor in Vendedores)
        {
            foreach (var producto in vendedor.Productos)
            {
                if (producto.Precio >= FiltMayor && producto.Precio <= FiltMenor &&
                        (producto.Nombre.Contains(textoBusqueda) ||
                            producto.Descripcion.Contains(textoBusqueda) ||
                                producto.categoria.Nombre.Contains(textoBusqueda)))
                {
                    ProductosEncontrados.Add(producto);
                }

            }
        }
        return ProductosEncontrados;
    }
    public List<Producto> BuscarProductosPorTextoLibre()
    {

        foreach (var vendedor in Vendedores)
        {
            foreach (var producto in vendedor.Productos)
            {
                if (producto.Nombre.Contains(textoBusqueda) ||
                        producto.Descripcion.Contains(textoBusqueda) ||
                            producto.categoria.Nombre.Contains(textoBusqueda))
                {
                    ProductosEncontrados.Add(producto);
                }

            }
        }
        return ProductosEncontrados;
    }
}




