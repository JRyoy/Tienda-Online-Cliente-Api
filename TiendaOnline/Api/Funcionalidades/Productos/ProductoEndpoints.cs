using Varios;
namespace Api.Funcionalidades.Productos;

public static class ProductoEndpoints
{
    public static void AddProductoEndpoints(this WebApplication app)
    {
        app.MapGet("/api/producto",(ProductoService productoService )=>
        {
            return Results.Ok(productoService.GetProductos());
        });
    }
}
