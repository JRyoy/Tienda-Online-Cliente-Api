namespace Varios;

public class Cliente : Vendedor
{
    List<Carrito> Carritos { get; set; }

    public Cliente(Guid Id, string Nombre, string Apellido, string Email, string Apodo, string Password) :
    base(Id, Nombre, Apellido, Email, Apodo, Password)
    {
        this.Carritos = new List<Carrito>();
    }
}
