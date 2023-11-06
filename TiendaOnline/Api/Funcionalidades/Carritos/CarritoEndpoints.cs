using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Carritos;

public class CarritoEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        #region 

        app.MapGet("/api/Carrito",([FromServices]ICarritoService carritoService)=>
        {
            return Results.Ok(carritoService.GetCarrito());
        });
        
        app.MapPost("/api/Carrito",([FromServices]ICarritoService carritoService,CarritoDto carritoDto)=>
        {
            carritoService.CreateCarrito(carritoDto);
            return Results.Ok();
        });
        app.MapPut("/api/Carrito/{carritoid}",([FromServices]ICarritoService carritoService,CarritoDto carritoDto,Guid carritoid)=>
        {
            carritoService.UpdateCarrito(carritoid,carritoDto);
            return Results.Ok();
        });
        app.MapDelete("/api/Carrito/{carritoid}",([FromServices]ICarritoService carritoService,Guid carritoid)=>
        {
            carritoService.DeleteCarrito(carritoid);
            return Results.Ok();
        });
        #endregion
        #region ListItem
        app.MapPost("/api/Carrito/{carritoid}/itemcarrito/{itemcarritoid}",([FromServices]ICarritoService carritoService,Guid carritoid,Guid itemcarritoid)=>
        {
            carritoService.AddItemcarrito(carritoid,itemcarritoid);
            return Results.Ok();
        });
        #endregion
    }

}
