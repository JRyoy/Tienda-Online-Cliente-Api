using Api.Funcionalidades.Productos;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Varios;

namespace Api.Funcionalidades.Categorias;

public interface ICategoriaService
{
    void AddCategoria(Guid categoriaid, Guid productoid);
    void CreateCategoria(CategoriaDto categoriaDto);
    void DaleteCategoria(Guid categoriaid);
    void Daleteproducto(Guid categoriaid, Guid productoid);
    List<CategoriaQueryDto>GetCategoria();
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
        var categoria= context.Categorias.Where(x=>x.IdCategoria==categoriaid).Include(x => x.Productos).First();
        var producto = categoria.Productos.FirstOrDefault(x => x.Id ==productoid);
        if(categoria !=null && producto!=null)
        {
            categoria.Productos.Remove(producto);
            context.SaveChanges();
        }
    }

    public List<CategoriaQueryDto>GetCategoria()
    {
        return context.Categorias.Include(x => x.Productos)
        .Select(x=> new CategoriaQueryDto
        {
            Id=x.IdCategoria,
            Nombre=x.Nombre,
            Descripcion=x.Descripcion,
            Productos = x.Productos.Select(y =>new ProductoQueryDto{Id=y.Id,Nombre=y.Nombre,Precio=y.Precio,Stock=y.Stock}).ToList()
        }).ToList();
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