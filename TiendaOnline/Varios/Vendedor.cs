using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Varios;
[Table("Vendedor")]
public class Vendedor
{

    [Key]
    [Required]
    public Guid Id { get; protected set; } = Guid.NewGuid();
    [Required]
    [StringLength(30)]
    public string Nombre { get; set; }
    [Required]
    [StringLength(30)]
    public string Apellido { get; set; }
    [Required]
    [StringLength(30)]
    public string Email { get; set; }
    [Required]
    [StringLength(30)]
    public string Apodo { get; set; }
    [Required]
    public string Password { get; set; }

    public List<Producto> Productos { get; set; } = new List<Producto>();
    public Vendedor(string Nombre, string Apellido, string Email, string Apodo, string Password)
    {
        Validacion.ValidacionCadena(Nombre, "error Nombre");
        this.Nombre = Nombre;
        Validacion.ValidacionCadena(Apellido, "error Apllido");
        this.Apellido = Apellido;
        Validacion.ValidarEmail(Email, "error Email");
        this.Email = Email;
        Validacion.ValidacionCadena(Password, "error Contraseña");
        this.Password = Password;
        Validacion.ValidacionCadena(Apodo, "error Apodo");
        this.Apodo = Apodo;

    }
    public void AgregarProductos(Producto producto)=>Productos.Add(producto);


}
