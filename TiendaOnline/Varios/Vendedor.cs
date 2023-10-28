namespace Varios;

public class Vendedor
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public  string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Email {get; set;}
    public  string Apodo {get; set;}
    public string Password{get; set;}
    
    public List<Producto>Productos{ get; set; } = new List<Producto>();
    public Vendedor (Guid Id,string Nombre, string Apellido,string Email,string Apodo,string Password)
    {
        this.Id= Guid.NewGuid();
        Validacion.ValidacionCadena(Nombre,"error Nombre");
        this.Nombre=Nombre;
        Validacion.ValidacionCadena(Apellido,"error Apllido");
        this.Apellido= Apellido;
        Validacion.ValidarEmail(Email,"error Email");
        this.Email= Email;
        Validacion.ValidacionCadena(Password,"error Contraseña");
        this.Password=Password;
        Validacion.ValidacionCadena(Apodo,"error Apodo");
        this.Apodo=Apodo;
        
    }   
    public void AgregarProductos(Producto producto)
    {
        Productos.Add(producto);
    }

    
}
