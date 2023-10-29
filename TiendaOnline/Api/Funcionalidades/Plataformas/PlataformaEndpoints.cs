using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Plataformas;

public static class PlataformaEndpoints
{
    public static void AddPlataformaEndpoints(this WebApplication app)
    {
        app.MapGet("/api/producto",([FromServices]IPlataformaService plataformaService)=>
        {
            return Results.Ok(plataformaService.GetPlataformas());
        });
    }

}
