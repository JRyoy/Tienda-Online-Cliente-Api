using Carter;
using Microsoft.AspNetCore.Mvc;
using Varios;

namespace Api.Funcionalidades.Clientes;

public class ClienteEndpoints:ICarterModule
{

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Cliente",([FromServices]IClienteService clienteService )=>
        {
            return Results.Ok(clienteService.GetClientes());
        });
        app.MapPost("/api/Cliente",([FromServices]IClienteService clienteService,ClienteDto clienteDto )=>
        {
            clienteService.CreateClientes(clienteDto);
            return Results.Ok();
        });
        app.MapPut("/api/Cliente/{clienteid}",([FromServices]IClienteService clienteService,Guid clienteid ,ClienteDto clienteDto )=>
        {
            clienteService.UpdateClientes(clienteid,clienteDto);
            return Results.Ok();
        });
        app.MapDelete("/api/Cliente/{clienteid}",([FromServices]IClienteService clienteService,Guid clienteid  )=>
        {
            clienteService.DeleteClientes(clienteid);
            return Results.Ok();
        });
    }

}
