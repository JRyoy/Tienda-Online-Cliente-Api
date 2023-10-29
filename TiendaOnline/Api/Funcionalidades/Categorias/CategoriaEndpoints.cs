namespace Api.Funcionalidades.Categorias;

public static class CategoriaEndpoints
{
    public static void AddCategoriaEndpoint(this WebApplication app)
    {
         app.MapGet("/api/categoria",(CategoriaService categoriaService)  =>
        {
            return Results.Ok(categoriaService.GetCategoria());
        });
    }
}
