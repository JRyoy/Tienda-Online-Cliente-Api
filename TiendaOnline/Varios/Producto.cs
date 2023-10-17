namespace Varios;

public class Producto
{
    public Guid Id { get; protected set; } 
    public string Nombre {get; set;}
    public double Precio {get;set;}
    public string Descripcion{get; set;}
    public string Categoria{get; set;}
    public int CantidadProducto{get; set;}
    
    public Producto(Guid Id,string Nombre,double Precio,string Descripcion,string Categoria)
    {
        
        this.Id=Id;
        Validacion.ValidacionValor(Precio,"error precio");
        this.Precio=Precio;
        Validacion.ValidacionCadena(Nombre,"error Nombre");
        this.Nombre= Nombre;
        Validacion.ValidacionCadena(Descripcion,"error descripcion");
        this.Descripcion=Descripcion;
        Validacion.ValidarCategoria(Categoria);
        this.Categoria=Categoria;


    }
}
