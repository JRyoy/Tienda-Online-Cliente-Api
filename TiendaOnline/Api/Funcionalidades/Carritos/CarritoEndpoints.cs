using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Carritos;

public static class CarritoEndpoints
{
    public static void AddCarritoEndpoints(this WebApplication app)
    {
        app.MapGet("/api/Carrito",([FromServices]ICarritoService carritoService)=>
        {
            return Results.Ok(carritoService.GetCarrito());
        });
    }
}
