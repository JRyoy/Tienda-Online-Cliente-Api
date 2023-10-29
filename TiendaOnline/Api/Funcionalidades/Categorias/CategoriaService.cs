using Varios;

namespace Api.Funcionalidades.Categorias;

public interface ICategoriaService
{
    List<Categoria>GetCategoria();
}
public class CategoriaService:ICategoriaService
{
    List<Categoria>categorias;
    public CategoriaService()
    {
        categorias=new List<Categoria>{};
    }
    public List<Categoria>GetCategoria()
    {
        return categorias;
    }
}
