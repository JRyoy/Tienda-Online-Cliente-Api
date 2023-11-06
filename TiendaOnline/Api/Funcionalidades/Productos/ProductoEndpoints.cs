using Carter;
using Microsoft.AspNetCore.Mvc;
using Varios;
namespace Api.Funcionalidades.Productos;

public  class ProductoEndpoints:ICarterModule
{

    public void AddRoutes(IEndpointRouteBuilder app)
    {
            app.MapGet("/api/producto",([FromServices]IProductoService productoService )=>
        {
            return Results.Ok(productoService.GetProductos());
        });
            app.MapPost("/api/producto",([FromServices]IProductoService productoService ,ProductoDto productoDto)=>
        {
            productoService.Createproducto(productoDto);
                return Results.Ok();
        });
            app.MapPut("/api/producto/{productoId}",([FromServices]IProductoService productoService, Guid  productoid,ProductoDto productoDto )=>
        {
               productoService.Updateproducto(productoid ,productoDto);
                return Results.Ok();
        });
            app.MapDelete("/api/producto/{productoId}",([FromServices]IProductoService productoService, Guid productoid)=>
        {
                productoService.Daleteproducto(productoid);
                return Results.Ok();
        });

    }

}
