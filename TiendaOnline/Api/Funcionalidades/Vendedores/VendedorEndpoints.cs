using Carter;
using Microsoft.AspNetCore.Mvc;
using Varios;

namespace Api.Funcionalidades.Vendedores;

public  class VendedorEndpoints:ICarterModule
    {
    public void AddRoutes(IEndpointRouteBuilder app)
    {
          app.MapGet("/api/vendedor", ([FromServices]IVendedorService vendedorService) =>
            {
                return Results.Ok(vendedorService.GetVendedores());
            });
    }
}
