using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Categorias;

public interface ICategoriaService
{
    List<Categoria>GetCategoria();
}
public class CategoriaService:ICategoriaService
{
     private readonly AplicacionDbContext context;
    public CategoriaService(AplicacionDbContext context)
    {
        this.context = context;
    }
    public List<Categoria>GetCategoria()
    {
        return context.Categorias.ToList();
    }
}
