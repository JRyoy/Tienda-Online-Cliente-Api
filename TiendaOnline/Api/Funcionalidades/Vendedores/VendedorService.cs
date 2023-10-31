using Api.Persistencia;
using Varios;
namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService
{
    List<Vendedor> GetVendedores();
}
public class VendedorService : IVendedorService
{
    private readonly AplicacionDBContext context;

    public VendedorService(AplicacionDBContext context)
    {
        this.context = context;
    }
    public List<Vendedor> GetVendedores()
    {
        return context.Vendedores.ToList();
    }
}
