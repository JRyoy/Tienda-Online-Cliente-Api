using Api.Persistencia;
using Varios;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService
{
    void CreateClientes(ClienteDto clienteDto);
    void DeleteClientes(Guid clienteid);
    List<Cliente>GetClientes();
    void UpdateClientes(Guid clienteid ,ClienteDto clienteDto);
}
public class ClienteService:IClienteService
{
    private readonly AplicacionDbContext context;
    public ClienteService(AplicacionDbContext context)
    {
         this.context = context;
    }

    public void CreateClientes(ClienteDto clienteDto)
    {
        context.Clientes.Add(new Cliente(clienteDto.Nombre,clienteDto.Apellido,
        clienteDto.Email,clienteDto.Apodo, clienteDto.Password));
        context.SaveChanges();
    }

    public void DeleteClientes(Guid clienteid)
    {
        var cliente=context.Clientes.FirstOrDefault(x=>x.Id==clienteid);
        if(cliente!=null)
        {
            context.Remove(cliente);
            context.SaveChanges();
        }
    }

    public List<Cliente>GetClientes()
    {
        return context.Clientes.ToList();
    }

    public void UpdateClientes(Guid clienteid,ClienteDto clienteDto)
    {
        var cliente = context.Clientes.FirstOrDefault(x => x.Id == clienteid);
        if(cliente != null)
        {
            cliente.Nombre=clienteDto.Nombre;
            cliente.Apellido=clienteDto.Apellido;
            cliente.Email=clienteDto.Email;
            cliente.Apodo=clienteDto.Apodo;
            cliente.Password=clienteDto.Password;
            context.SaveChanges();
        }
    }
}
