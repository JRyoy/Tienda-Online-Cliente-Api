namespace Varios;

public class Categoria
{
    public Guid IdCategoria { get; protected set; } = Guid.NewGuid();
    public string Nombre {get; set;}
    public string Descripcion{get; set;}
    public Categoria(Guid Id,string Nombre, string Descripcion)
    {
        this.IdCategoria=IdCategoria;
        this.Nombre=Nombre;
        this.Descripcion=Descripcion;
    }
}
