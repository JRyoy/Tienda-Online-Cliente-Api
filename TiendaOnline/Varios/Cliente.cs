using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Varios;
[Table("Cliente")]
public class Cliente : Vendedor
{

    public List<Carrito> Carritos { get; set; }
    public Cliente(string Nombre, string Apellido, string Email, string Apodo, string Password) :
        base(Nombre, Apellido, Email, Apodo, Password)
    {
        Validacion.ValidarEmail(Email, "error email");
        this.Carritos = new List<Carrito>();
    }
    public void AgregarCarrito(Carrito carrito)=>Carritos.Add(carrito); 

}
