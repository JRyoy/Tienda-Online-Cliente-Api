using System.ComponentModel.DataAnnotations;

namespace Varios;

public class Categoria
{
    [Key]
    [Required]
    public Guid IdCategoria { get; protected set; } = Guid.NewGuid();
    [Required]
    [StringLength(30)]
    public string Nombre { get; set; }
    [Required]
    [StringLength(30)]
    public string Descripcion { get; set; }
    List<Producto> Productos { get; set; }

    public Categoria( Guid Id, string Nombre, string Descripcion)
    {
        this.IdCategoria = IdCategoria;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.Productos = new List<Producto>();
    }
}
