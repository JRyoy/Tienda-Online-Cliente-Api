namespace Varios;

public class Categoria
{
    public Guid IdCategoria { get; protected set; } = Guid.NewGuid();
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    List<Producto> Productos { get; set; }

    public Categoria(Guid IdCategoria, string Nombre, string Descripcion)
    {
        this.IdCategoria = IdCategoria;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.Productos = new List<Producto>();
    }
}
