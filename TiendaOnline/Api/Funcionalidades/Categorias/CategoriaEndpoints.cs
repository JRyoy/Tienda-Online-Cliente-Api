using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Categorias;

public  class CategoriaEndpoints:ICarterModule
{


    public void AddRoutes(IEndpointRouteBuilder app)
    {
         app.MapGet("/api/categoria",([FromServices]ICategoriaService categoriaService)  =>
        {
            return Results.Ok(categoriaService.GetCategoria());
        });
    }

}
