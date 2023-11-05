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
        app.MapPut("/api/Vendedor/{vendedorId}}",([FromServices]IVendedorService vendedorService,Guid  vendedorId ,VendedorDto vendedorDto)=>
        {
                vendedorService.Updatevendedor(vendedorId,vendedorDto);
                return Results.Ok();
        });
        app.MapPut("/api/Vendedor/{vendedorId}}",([FromServices]IVendedorService vendedorService,Guid  vendedorId )=>
        {
                vendedorService.Daletevendedor(vendedorId);
                return Results.Ok();
        });
    }
}
