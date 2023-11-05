using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Categorias;

public interface ICategoriaService
{
    List<Categoria>GetCategoria();
}
public class CategoriaService:ICategoriaService
{
     private readonly AplicacionDBContext context;
    public CategoriaService(AplicacionDBContext context)
    {
        this.context = context;
    }
    public List<Categoria>GetCategoria()
    {
        return context.Categorias.ToList();
    }
}
