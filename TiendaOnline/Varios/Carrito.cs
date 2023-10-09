namespace Varios;

public class Carrito
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public  Clientes Cliente {get; set;}
    List<Producto> Productos{get; set;}
    public Carrito (Guid Id, Clientes Cliente )
    {
        this.Id=Id;
        this.Cliente=Cliente;
    }
    public void AgregarProductos(Producto producto)
    {
        Productos.Add(producto);
    }
}
