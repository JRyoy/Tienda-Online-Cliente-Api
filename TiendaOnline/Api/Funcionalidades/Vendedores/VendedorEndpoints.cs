using Carter;
using Microsoft.AspNetCore.Mvc;
using Varios;

namespace Api.Funcionalidades.Vendedores;

public  class VendedorEndpoints:ICarterModule
    {
    public void AddRoutes(IEndpointRouteBuilder app)
    {
            app.MapGet("/api/Vendedor", ([FromServices]IVendedorService vendedorService) =>
            {
                return Results.Ok(vendedorService.GetVendedores());
            });

            app.MapPost("/api/Vendedor",([FromServices]IVendedorService vendedorService,VendedorDto vendedorDto)=>
        {
            vendedorService.Createvendedor(vendedorDto);
                return Results.Ok();
        });
            app.MapPut("/api/Vendedor/{vendedorId}",([FromServices]IVendedorService vendedorService,Guid  vendedorid ,VendedorDto vendedorDto)=>
        {
                vendedorService.Updatevendedor(vendedorid,vendedorDto);
                return Results.Ok();
        });
            app.MapDelete("/api/Vendedor/{vendedorId}",([FromServices]IVendedorService vendedorService,Guid  vendedorid )=>
        {
                vendedorService.Daletevendedor(vendedorid);
                return Results.Ok();
        });
            app.MapPost("/api/Vendedor/{vendedorid/producto/{productoid}}",([FromServices]IVendedorService vendedorService,Guid vendedorid,Guid productoid)=>
        {
            vendedorService.Addproducto(vendedorid,productoid);
                return Results.Ok();
        });
            app.MapDelete("/api/Vendedor/{vendedorid/producto/{productoid}/Delete",([FromServices]IVendedorService vendedorService,Guid vendedorid,Guid productoid)=>
        {
            vendedorService.Deleteproducto(vendedorid,productoid);
                return Results.Ok();
        });
    }
}
