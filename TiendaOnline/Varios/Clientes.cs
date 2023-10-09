namespace Varios;

public class Clientes:Vendedor
{
    List<Carrito> Carritos{get; set;}
    
    public enum cliente{}
    public Clientes(Guid Id,string Nombre, string Apellido,string Email,string Apodo,string Password):
    base(Id, Nombre,  Apellido, Email, Apodo, Password)
    {
        this.Carritos=new List<Carrito>();
    }
}
