using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Varios;
[Table("Categoria")]
public class Categoria
{
    [Key]
    [Required]
    public Guid IdCategoria { get; protected set; } = Guid.NewGuid();
    [Required]
    [StringLength(30)]
    public string Nombre { get; set; }
    [Required]
    [StringLength(100)]
    public string Descripcion { get; set; }= string.Empty;
    List<Producto> Productos { get; set; }

    public Categoria(string Nombre, string Descripcion)
    {
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.Productos = new List<Producto>();
    }
    public void AgregarProductos(Producto producto)=>Productos.Add(producto);
}
