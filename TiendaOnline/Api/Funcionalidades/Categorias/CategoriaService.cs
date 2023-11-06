using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Categorias;

public interface ICategoriaService
{
    void AddCategoria(Guid categoriaid, Guid productoid);
    void CreateCategoria(CategoriaDto categoriaDto);
    void DaleteCategoria(Guid categoriaid);
    void Daleteproducto(Guid categoriaid, Guid productoid);
    List<Categoria>GetCategoria();
    void UpdateCategoria(Guid categoriaid, CategoriaDto categoriaDto);
}
public class CategoriaService:ICategoriaService
{
     private readonly AplicacionDbContext context;
    public CategoriaService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void AddCategoria(Guid categoriaid, Guid productoid)
    {
        var categoria= context.Categorias.FirstOrDefault(x=>x.IdCategoria==categoriaid);
        var producto = context.Productos.FirstOrDefault(x => x.Id ==productoid);
        if(categoria !=null && producto!=null)
        {
            categoria.AgregarProductos(producto);
            context.SaveChanges();
        }
    }

    public void CreateCategoria(CategoriaDto categoriaDto)
    {
        context.Categorias.Add(new Categoria(categoriaDto.Nombre,categoriaDto.Descripcion));
        context.SaveChanges();
    }

    public void DaleteCategoria(Guid categoriaid)
    {
        var categoria= context.Categorias.FirstOrDefault(x=>x.IdCategoria==categoriaid);
        if(categoria !=null)
        {
            context.Remove(categoria);
            context.SaveChanges();
        }
    }

    public void Daleteproducto(Guid categoriaid, Guid productoid)
    {
         var categoria= context.Categorias.FirstOrDefault(x=>x.IdCategoria==categoriaid);
        var producto = context.Productos.FirstOrDefault(x => x.Id ==productoid);
        if(categoria !=null && producto!=null)
        {
            context.Remove(producto);
            context.SaveChanges();
        }
    }

    public List<Categoria>GetCategoria()
    {
        return context.Categorias.ToList();
    }

    public void UpdateCategoria(Guid categoriaid, CategoriaDto categoriaDto)
    {
        var categoria= context.Categorias.FirstOrDefault(x=>x.IdCategoria==categoriaid);
        if(categoria !=null)
        {
            categoria.Nombre=categoriaDto.Nombre;
            categoria.Descripcion=categoria.Descripcion;
            context.SaveChanges();
        }
    }
}
