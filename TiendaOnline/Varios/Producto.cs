namespace Varios;

public class Producto
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public string Nombre {get; set;}
    public double Precio {get;set;}
    public string Descripcion{get; set;}
    public string Categoria{get; set;}
    
    public Producto(Guid Id,string Nombre,double Precio,string Descripcion,string Categoria)
    {
        this.Id=Id;
        Validacion.ValidacionValor(Precio,"error precio");
        this.Precio=Precio;
        Validacion.ValidacionCadena(Nombre,"error Nombre");
        this.Nombre= Nombre;
        this.Descripcion=Descripcion;
        this.Categoria=Categoria;

    }
}
