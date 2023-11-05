namespace Api.Funcionalidades.ItemCarritos;

using Api.Persistencia;
using Varios;
public interface IItemCarritoService
{
    List<ItemCarrito>GetItemCarritos();
}
public  class ItemCarritoService:IItemCarritoService
{
    private readonly AplicacionDBContext context;
    public ItemCarritoService(AplicacionDBContext context)
    {
        this.context = context;

    }
    public List<ItemCarrito>GetItemCarritos()
    {
        return context.ItemCarritos.ToList();
    }
}
