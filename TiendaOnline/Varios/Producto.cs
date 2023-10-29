using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Varios;
[Table("Producto")]
public class Producto
{
   [Key]
   [Required]
    public Guid Id { get; protected set; }
    [Required]
    [StringLength(30)]
    public string Nombre { get; set; }
    [Required]
    public double Precio { get; set; }
    [Required]
    [StringLength(50)]      
    public string Descripcion { get; set; }
    [Required]
    public Categoria categoria { get; set; }
    [Required]
    public int CantidadProducto { get; set; }

    public Producto( string Nombre, double Precio, string Descripcion, Categoria categoria)
    {

        this.Id = Id;
        Validacion.ValidacionValor(Precio, "error precio");
        this.Precio = Precio;
        Validacion.ValidacionCadena(Nombre, "error Nombre");
        this.Nombre = Nombre;
        Validacion.ValidacionCadena(Descripcion, "error descripcion");
        this.Descripcion = Descripcion;
        this.categoria = categoria;


    }
}
