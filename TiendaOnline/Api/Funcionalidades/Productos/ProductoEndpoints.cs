using Microsoft.AspNetCore.Mvc;
using Varios;
namespace Api.Funcionalidades.Productos;

public static class ProductoEndpoints
{
    public static void AddProductoEndpoints(this WebApplication app)
    {
        app.MapGet("/api/producto",([FromServices]IProductoService productoService )=>
        {
            return Results.Ok(productoService.GetProductos());
        });
    }
}
