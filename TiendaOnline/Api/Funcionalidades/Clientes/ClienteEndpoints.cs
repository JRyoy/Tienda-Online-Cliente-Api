using Microsoft.AspNetCore.Mvc;
using Varios;

namespace Api.Funcionalidades.Clientes;

public static class ClienteEndpoints
{
    public static void AddClienteEndpoints(this WebApplication app)
    {
        app.MapGet("/api/Cliente",([FromServices]IClienteService clienteService )=>
        {
            return Results.Ok(clienteService.GetClientes());
        });
    }
}
