using System.Runtime.CompilerServices;
using Api.Funcionalidades.Productos;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Varios;
namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService
{
    void Addproducto(Guid vendedorid, Guid productoid);
    void Createvendedor(VendedorCommandDto vendedorDto);
    void Daletevendedor(Guid vendedorid);
    void Deleteproducto(Guid vendedorid, Guid productoid);
    List<VendedorQueryDto> GetVendedores();
    void Updatevendedor(Guid vendedorid, VendedorCommandDto vendedorDto);
}
public class VendedorService : IVendedorService
{
    private readonly AplicacionDbContext context;

    public VendedorService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void Addproducto(Guid vendedorid, Guid productoid)
    {
        var producto = context.Productos.FirstOrDefault(x => x.Id == productoid);
        var vendedor = context.Vendedores.FirstOrDefault(x => x.Id == vendedorid);
        if (vendedor != null && producto != null)
        {
            vendedor.AgregarProductos(producto);
            context.SaveChanges();
        }
    }

    public void Createvendedor(VendedorCommandDto vendedorDto)
    {
        context.Vendedores.Add(new Vendedor(vendedorDto.Nombre, vendedorDto.Apellido,
        vendedorDto.Email, vendedorDto.Apodo, vendedorDto.Password));
        context.SaveChanges();
    }

    public void Daletevendedor(Guid vendedorid)
    {
        var vendedor = context.Vendedores.FirstOrDefault(x => x.Id == vendedorid);
        if (vendedor != null)
        {
            context.Remove(vendedor);
            context.SaveChanges();
        }
    }

    public void Deleteproducto(Guid vendedorid, Guid productoid)
    {
        var vendedor = context.Vendedores.FirstOrDefault(x => x.Id == vendedorid);
        var producto = context.Productos.FirstOrDefault(x => x.Id == productoid);
        if (vendedor != null)
        {
            context.Remove(producto);
            context.SaveChanges();
        }

    }

    public List<VendedorQueryDto> GetVendedores()
    {
        return context.Vendedores.Include(x => x.Productos)
        .Select(x => new VendedorQueryDto
        {
            Id = x.Id,
            Apellido = x.Apellido,
            Email = x.Email,
            Apodo = x.Apodo,
            Password = x.Password,
            Productos = x.Productos.Select(y => new ProductoQueryDto { Id = y.Id, Nombre = y.Nombre, Precio = y.Precio, Stock = y.Stock }).ToList()
        }).ToList();
    }

    public void Updatevendedor(Guid vendedorid, VendedorCommandDto vendedorDto)
    {
        var vendedor = context.Vendedores.FirstOrDefault(x => x.Id == vendedorid);
        if (vendedor != null)
        {
            vendedor.Nombre = vendedorDto.Nombre;
            vendedor.Apellido = vendedorDto.Apellido;
            vendedor.Email = vendedorDto.Email;
            vendedor.Apodo = vendedorDto.Apodo;
            vendedor.Password = vendedorDto.Password;
            context.SaveChanges();
        }
    }
}
