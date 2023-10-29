using Varios;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService
{
    List<Cliente>GetClientes();
}
public class ClienteService:IClienteService
{
    List<Cliente>clientes;
    public ClienteService()
    {
        clientes=new List<Cliente>{};
    }
    public List<Cliente>GetClientes()
    {
        return clientes;
    }
}
