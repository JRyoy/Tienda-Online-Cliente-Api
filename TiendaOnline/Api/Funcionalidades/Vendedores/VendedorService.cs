using Api.Persistencia;
using Varios;
namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService
{
    List<Vendedor> GetVendedores();
}
public class VendedorService : IVendedorService
{
    private readonly AplicacionDbContext context;

    public VendedorService(AplicacionDbContext context)
    {
        this.context = context;
    }
    public List<Vendedor> GetVendedores()
    {
        return context.Vendedores.ToList();
    }
}
