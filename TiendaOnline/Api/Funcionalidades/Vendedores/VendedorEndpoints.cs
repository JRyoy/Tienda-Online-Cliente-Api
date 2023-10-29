using Microsoft.AspNetCore.Mvc;
using Varios;

namespace Api.Funcionalidades.Vendedores;

public static class VendedorEndpoints
    {
        public static void AddVendedorEndpoints(this WebApplication app)
        {
            app.MapGet("/api/vendedor", ([FromServices]IVendedorService vendedorService) =>
            {
                return Results.Ok(vendedorService.GetVendedores());
            });
        }
    }
