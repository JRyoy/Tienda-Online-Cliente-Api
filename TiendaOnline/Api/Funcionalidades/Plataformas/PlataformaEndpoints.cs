using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Plataformas;

public  class PlataformaEndpoints:ICarterModule
{


    public void AddRoutes(IEndpointRouteBuilder app)
    {
       app.MapGet("/api/plataforma",([FromServices]IPlataformaService plataformaService)=>
        {
            return Results.Ok(plataformaService.GetPlataformas());
        });
    }
}
