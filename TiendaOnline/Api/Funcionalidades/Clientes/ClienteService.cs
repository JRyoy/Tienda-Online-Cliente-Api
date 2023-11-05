using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService
{
    List<Cliente>GetClientes();
}
public class ClienteService:IClienteService
{
    private readonly AplicacionDBContext context;
    public ClienteService(AplicacionDBContext context)
    {
         this.context = context;
    }
    public List<Cliente>GetClientes()
    {
        return context.Clientes.ToList();
    }
}
