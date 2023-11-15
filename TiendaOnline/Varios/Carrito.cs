using System.ComponentModel.DataAnnotations;

namespace Varios;

public class Carrito
{
    [Key]
    [Required]
    public Guid Id { get; protected set; } = Guid.NewGuid();
    [Required]
    public Guid IdCliente { get; set; }
    [Required]
    public double Total { get; set; }
    public List<ItemCarrito> Productos { get; set; }


    public Carrito() { }

    public Carrito(Guid IdCliente)
    {
        this.IdCliente = IdCliente;
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
            if (itemCarrito.Producto.Stock >= itemCarrito.Cantidad)
                itemCarrito.Producto.Stock -= itemCarrito.Cantidad;
            else
                throw new Exception($"No hay suficiente stock para {itemCarrito.Producto.Nombre}");

        }
    }
}