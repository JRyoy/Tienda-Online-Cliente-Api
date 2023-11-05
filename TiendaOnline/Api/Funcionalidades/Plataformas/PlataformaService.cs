namespace Api.Funcionalidades.Plataformas;
using Varios;
public interface IPlataformaService
{
    List<Plataforma> GetPlataformas();
}
public class PlataformaService:IPlataformaService
{
    List<Plataforma> plataformas;
    public PlataformaService()
    {
        plataformas=new List<Plataforma>
        {

        };
    }
    public List<Plataforma>GetPlataformas()
    {
        return plataformas;
    }
}
