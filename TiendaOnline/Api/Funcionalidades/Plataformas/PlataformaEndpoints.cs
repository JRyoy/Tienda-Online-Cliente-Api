namespace Api.Funcionalidades.Plataformas;

public static class PlataformaEndpoints
{
    public static void AddPlataformaEndpoints(this WebApplication app)
    {
        app.MapGet("/api/producto",(PlataformaService plataformaService)=>
        {
            return Results.Ok(plataformaService.GetPlataformas());
        });
    }

}
