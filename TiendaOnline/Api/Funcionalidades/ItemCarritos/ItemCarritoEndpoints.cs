using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.ItemCarritos;

public  class ItemCarritoEndpoints:ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
       app.MapGet("/api/itemCarrito",([FromServices]IItemCarritoService itemCarritoService)=>
        {
            return Results.Ok(itemCarritoService.GetItemCarritos());
        });
    }

}
