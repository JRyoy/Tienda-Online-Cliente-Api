namespace Api.Funcionalidades.Carritos;

public static class CarritoEndpoints
{
    public static void AddCarritoEndpoints(this WebApplication app)
    {
        app.MapGet("/api/Carrito",(CarritoService carritoService)=>
        {
            return Results.Ok(carritoService.GetCarrito());
        });
    }
}
