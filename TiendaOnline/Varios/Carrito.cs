namespace Varios;

public class Carrito
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public Cliente Cliente { get; set; }
    public double Total { get; set; }
    List<ItemCarrito> Productos { get; set; }

    public Carrito(Guid Id, Cliente Cliente)
    {
        this.Id = Id;
        this.Cliente = Cliente;
        Productos = new List<ItemCarrito>();
        Total = 0;
    }

    public void AgregarProductos(Producto producto, int cantidad)
    {
        var itemProducto = Productos.SingleOrDefault(x => x.Producto.Id == producto.Id);

        if (itemProducto != null)
        {
            itemProducto.Cantidad += cantidad;
            itemProducto.Subtotal = itemProducto.Producto.Precio * itemProducto.Cantidad;
        }
        else
            Productos.Add(new ItemCarrito(producto, cantidad));

        Total = Productos.Sum(x => x.Subtotal);
    }

    public void Comprar()
    {
        foreach (var itemCarrito in Productos)
        {
            if (itemCarrito.Producto.CantidadProducto >= itemCarrito.Cantidad)
                itemCarrito.Producto.CantidadProducto -= itemCarrito.Cantidad;
            else
                throw new Exception($"No hay suficiente stock para {itemCarrito.Producto.Nombre}");

        }
    }
}