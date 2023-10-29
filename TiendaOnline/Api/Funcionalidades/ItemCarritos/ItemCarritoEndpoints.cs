namespace Api.Funcionalidades.ItemCarritos;

public static class ItemCarritoEndpoints
{
    public static void AddItemCarritoEndpoints(this WebApplication app)
    {
        app.MapGet("/api/itemCarrito",(ItemCarritoService itemCarritoService)=>
        {
            return Results.Ok(itemCarritoService.GetItemCarritos());
        });
    }
}
