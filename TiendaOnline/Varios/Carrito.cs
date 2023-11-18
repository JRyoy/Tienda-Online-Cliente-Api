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

    public void AgregarProductos(ItemCarrito itemCarrito)
    {
        var itemProducto = Productos.SingleOrDefault(x => x.IdItemCarrito == itemCarrito.IdItemCarrito);

        if (itemProducto != null)
        {
            itemProducto.Cantidad += itemCarrito.Cantidad;
            itemProducto.Subtotal = itemProducto.Producto.Precio * itemProducto.Cantidad;
        }
        else
            Productos.Add(itemCarrito);

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