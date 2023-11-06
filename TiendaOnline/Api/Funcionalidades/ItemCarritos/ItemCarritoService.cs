namespace Api.Funcionalidades.ItemCarritos;

using System;
using Api.Persistencia;
using Varios;
public interface IItemCarritoService
{
    void CreateItemCarritos(ItemCarritoDto itemCarritoDto);
    void DeleteItemCarritos(Guid itemcarritoid);
    List<ItemCarrito>GetItemCarritos();
    void UpdateItemCarritos(Guid itemcarritoid, ItemCarritoDto itemCarritoDto);
}
public  class ItemCarritoService:IItemCarritoService
{
    private readonly AplicacionDbContext context;
    public ItemCarritoService(AplicacionDbContext context)
    {

        this.context = context;

    }

    public void CreateItemCarritos(ItemCarritoDto itemCarritoDto)
    {
        context.ItemCarritos.Add(new ItemCarrito(itemCarritoDto.Producto,itemCarritoDto.Cantidad));
        context.SaveChanges();
    }

    public void DeleteItemCarritos(Guid itemcarritoid)
    {
        var itemCarrito=context.ItemCarritos.FirstOrDefault(x=>x.Id ==itemcarritoid);
        if(itemCarrito!=null)
        {
            context.Remove(itemCarrito);
            context.SaveChanges();
        }
    }

    public List<ItemCarrito>GetItemCarritos()
    {
        return context.ItemCarritos.ToList();
    }

    public void UpdateItemCarritos(Guid itemcarritoid, ItemCarritoDto itemCarritoDto)
    {
        var itemCarrito=context.ItemCarritos.FirstOrDefault(x=>x.Id ==itemcarritoid);
        if(itemCarrito!=null)
        {
            itemCarrito.Producto=itemCarritoDto.Producto;
            itemCarrito.Cantidad=itemCarritoDto.Cantidad;
            context.SaveChanges();
        }
    }
}
