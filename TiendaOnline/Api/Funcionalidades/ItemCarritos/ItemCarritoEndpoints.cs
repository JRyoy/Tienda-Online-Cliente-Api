using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.ItemCarritos;

public static class ItemCarritoEndpoints
{
    public static void AddItemCarritoEndpoints(this WebApplication app)
    {
        app.MapGet("/api/itemCarrito",([FromServices]IItemCarritoService itemCarritoService)=>
        {
            return Results.Ok(itemCarritoService.GetItemCarritos());
        });
    }
}
