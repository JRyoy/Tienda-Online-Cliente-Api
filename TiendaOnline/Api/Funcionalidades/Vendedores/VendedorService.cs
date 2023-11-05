using Api.Persistencia;
using Varios;
namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService
{
    void Createvendedor(VendedorDto vendedorDto);
    void Daletevendedor(Guid vendedorId);
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

    public void Createvendedor(VendedorDto vendedorDto)
    {
        context.Vendedores.Add(new Vendedor(vendedorDto.Nombre,vendedorDto.Apellido,
        vendedorDto.Email,vendedorDto.Apodo, vendedorDto.Password));
        context.SaveChanges();
    }

    public void Daletevendedor(Guid vendedorId)
    {
                var vendedor=context.Vendedores.FirstOrDefault(x=>x.Id ==vendedorId);
        if (vendedor !=null)
        {
            context.Remove(vendedor);
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
