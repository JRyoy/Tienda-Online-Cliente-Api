using Api.Persistencia;
using Varios;
namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService
{
    void Addproducto(Guid vendedorid, Guid productoid);
    void Createvendedor(VendedorDto vendedorDto);
    void Daletevendedor(Guid vendedorid);
    void Deleteproducto(Guid vendedorid, Guid productoid);
    List<Vendedor> GetVendedores();
    void Updatevendedor(Guid  vendedorid,VendedorDto vendedorDto);
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
         var producto = context.Productos.FirstOrDefault(x => x.Id ==productoid);
         var vendedor=context.Vendedores.FirstOrDefault(x=>x.Id ==vendedorid);
         if (vendedor !=null && producto!=null)
        {
            vendedor.AgregarProductos(producto);
            context.SaveChanges();
        }
    }

    public void Createvendedor(VendedorDto vendedorDto)
    {
        context.Vendedores.Add(new Vendedor(vendedorDto.Nombre,vendedorDto.Apellido,
        vendedorDto.Email,vendedorDto.Apodo, vendedorDto.Password));
        context.SaveChanges();
    }

    public void Daletevendedor(Guid vendedorid)
    {
        var vendedor=context.Vendedores.FirstOrDefault(x=>x.Id ==vendedorid);
        if (vendedor !=null)
        {
            context.Remove(vendedor);
            context.SaveChanges();
        }
    }

    public void Deleteproducto(Guid vendedorid, Guid productoid)
    {
        var vendedor=context.Vendedores.FirstOrDefault(x=>x.Id ==vendedorid);
        var producto = context.Productos.FirstOrDefault(x => x.Id ==productoid);
        if (vendedor !=null)
        {
            context.Remove(producto);
            context.SaveChanges();
        }

    }

    public List<Vendedor> GetVendedores()
    {
        return context.Vendedores.ToList();
    }

    public void Updatevendedor(Guid vendedorid,VendedorDto vendedorDto)
    {
        var vendedor=context.Vendedores.FirstOrDefault(x=>x.Id ==vendedorid);
        if (vendedor !=null)
        {
        vendedor.Nombre=vendedorDto.Nombre;
        vendedor.Apellido=vendedorDto.Apellido;
        vendedor.Email=vendedorDto.Email;
        vendedor.Apodo=vendedorDto.Apodo;
        vendedor.Password=vendedorDto.Password;
        context.SaveChanges();
        }
    }
}
