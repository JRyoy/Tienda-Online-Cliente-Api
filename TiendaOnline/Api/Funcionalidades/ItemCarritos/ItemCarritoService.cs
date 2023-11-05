namespace Api.Funcionalidades.ItemCarritos;

using Api.Persistencia;
using Varios;
public interface IItemCarritoService
{
    List<ItemCarrito>GetItemCarritos();
}
public  class ItemCarritoService:IItemCarritoService
{
    private readonly AplicacionDbContext context;
    public ItemCarritoService(AplicacionDbContext context)
    {

        this.context = context;

    }
    public List<ItemCarrito>GetItemCarritos()
    {
        return context.ItemCarritos.ToList();
    }
}
