using System.ComponentModel.DataAnnotations;

namespace Varios;
public class ItemCarrito
{
    [Key]
    [Required]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]

    public Producto Producto { get; set; }
    [Required]
    public int Cantidad { get; set; }
    [Required]
    public double Subtotal { get; set; }

    public ItemCarrito() { }

    public ItemCarrito(Producto producto, int cantidad)
    {
        producto = producto;
        Cantidad = cantidad;
        Subtotal = producto.Precio * cantidad;
    }
}