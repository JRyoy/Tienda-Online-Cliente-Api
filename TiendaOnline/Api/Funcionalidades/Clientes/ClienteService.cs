using Api.Funcionalidades.Productos;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Varios;

namespace Api.Funcionalidades.Clientes;

public interface IClienteService
{
    void AddCarrito(Guid clienteid, Guid carritoid);
    void CreateClientes(ClienteCommandDto clienteDto);
    void Deletecarrito(Guid clienteid, Guid carritoid);
    void DeleteClientes(Guid clienteid);
    List<ClienteQueryDto> GetClientes();
    void UpdateClientes(Guid clienteid, ClienteCommandDto clienteDto);
}
public class ClienteService : IClienteService
{
    private readonly AplicacionDbContext context;
    public ClienteService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void AddCarrito(Guid clienteid, Guid carritoid)
    {
        var cliente = context.Clientes.FirstOrDefault(x => x.Id == clienteid);
        var carrito = context.Carritos.FirstOrDefault(x => x.Id == carritoid);
        if (cliente != null && carrito != null)
        {
            cliente.AgregarCarrito(carrito);
            context.SaveChanges();
        }

    }

    public void CreateClientes(ClienteCommandDto clienteDto)
    {
        context.Clientes.Add(new Cliente(clienteDto.Nombre, clienteDto.Apellido,
        clienteDto.Email, clienteDto.Apodo, clienteDto.Password));
        context.SaveChanges();
    }

    public void Deletecarrito(Guid clienteid, Guid carritoid)
    {
        var cliente = context.Clientes.FirstOrDefault(x => x.Id == clienteid);
        var carrito = context.Carritos.FirstOrDefault(x => x.Id == carritoid);
        if (cliente != null && carrito != null)
        {
            context.Remove(carrito);
            context.SaveChanges();
        }
    }

    public void DeleteClientes(Guid clienteid)
    {
        var cliente = context.Clientes.FirstOrDefault(x => x.Id == clienteid);
        if (cliente != null)
        {
            context.Remove(cliente);
            context.SaveChanges();
        }
    }

    public List<ClienteQueryDto> GetClientes()
    {
        return context.Clientes.Include(x => x.Productos)
        .Select(x => new ClienteQueryDto
        {
            Apellido = x.Apellido,
            Email = x.Email,
            Apodo = x.Apodo,
            Password = x.Password,
            Productos = x.Productos.Select(y => new ProductoQueryDto { Id = y.Id, Nombre = y.Nombre, Precio = y.Precio, Stock = y.Stock }).ToList()
        }).ToList();
    }

    public void UpdateClientes(Guid clienteid, ClienteCommandDto clienteDto)
    {
        var cliente = context.Clientes.FirstOrDefault(x => x.Id == clienteid);
        if (cliente != null)
        {
            cliente.Nombre = clienteDto.Nombre;
            cliente.Apellido = clienteDto.Apellido;
            cliente.Email = clienteDto.Email;
            cliente.Apodo = clienteDto.Apodo;
            cliente.Password = clienteDto.Password;
            context.SaveChanges();
        }
    }
}
