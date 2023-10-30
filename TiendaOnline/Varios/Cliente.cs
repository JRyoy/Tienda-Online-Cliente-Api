using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Varios;
[Table("Cliente")]
public class Cliente : Vendedor
{
    List<Carrito> Carritos { get; set; }
    public Cliente( Guid Id,string Nombre, string Apellido, string Email, string Apodo, string Password) :
    base( Id,Nombre, Apellido, Email, Apodo, Password)
    {
        Validacion.ValidarEmail(Email,"error email");
        this.Carritos = new List<Carrito>();
    }

}
