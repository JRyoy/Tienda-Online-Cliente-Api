namespace Api.Funcionalidades.ItemCarritos;
using Varios;
public interface IItemCarritoService
{
    List<ItemCarrito>GetItemCarritos();
}
public  class ItemCarritoService:IItemCarritoService
{
    List<ItemCarrito>itemCarritos;
    public ItemCarritoService()
    {
        itemCarritos=new List<ItemCarrito>{};

    }
    public List<ItemCarrito>GetItemCarritos()
    {
        return itemCarritos;
    }
}
