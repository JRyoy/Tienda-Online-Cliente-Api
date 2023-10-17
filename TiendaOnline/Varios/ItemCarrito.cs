namespace Varios;
public class ItemCarrito
{
    public Producto Producto { get; set; }

    public int Cantidad { get; set; }

    public double Subtotal { get; set; }

    public ItemCarrito(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
        Subtotal = producto.Precio * cantidad;
    }
}