using Varios;
namespace Api.Funcionalidades.Vendedores;

public interface  IVendedorService
{
    List<Vendedor>GetVendedores();
}
public class VendedorService : IVendedorService
{
    List<Vendedor> vendedores;
    public VendedorService()
    {
        vendedores=new List<Vendedor>
        {
            new Vendedor(Guid.NewGuid(),"Rias","Gremory","kk@gmail.com","delfin","dsfsdfv"),
            new Vendedor(Guid.NewGuid(),"Issei","hyodo","ññ@gmail.com","delfin","30851"),

        };
    }
    public List<Vendedor> GetVendedores()
    {
        return vendedores;
    }
}
