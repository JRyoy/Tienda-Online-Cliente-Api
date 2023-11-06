using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Categorias;

public  class CategoriaEndpoints:ICarterModule
{


    public void AddRoutes(IEndpointRouteBuilder app)
    {
         #region Categoria
         app.MapGet("/api/categoria",([FromServices]ICategoriaService categoriaService)  =>
        {
            return Results.Ok(categoriaService.GetCategoria());
        });
    
         app.MapPost("/api/categoria",([FromServices]ICategoriaService categoriaService,CategoriaDto categoriaDto)  =>
        {
            categoriaService.CreateCategoria(categoriaDto);
            return Results.Ok();
        });
         app.MapPut("/api/categoria/{categoriaid}",([FromServices]ICategoriaService categoriaService,CategoriaDto categoriaDto,Guid categoriaid)  =>
        {
            categoriaService.UpdateCategoria(categoriaid,categoriaDto);
            return Results.Ok();
        });
         app.MapDelete("/api/categoria/{categoriaid}",([FromServices]ICategoriaService categoriaService,Guid categoriaid)  =>
        {
            categoriaService.DaleteCategoria(categoriaid);
            return Results.Ok();
        });
        #endregion
        #region LisProducto
            
         app.MapPost("/api/categoria/{categoriaid}/producto/{productoid}",([FromServices]ICategoriaService categoriaService,Guid categoriaid,Guid productoid)  =>
        {
            categoriaService.AddCategoria(categoriaid,productoid);
            return Results.Ok();
        });
         app.MapDelete("/api/categoria/{categoriaid}/producto/{productoid}/Delete",([FromServices]ICategoriaService categoriaService,Guid categoriaid,Guid productoid)  =>
        {
            categoriaService.Daleteproducto(categoriaid,productoid);
            return Results.Ok();
        });
        
        #endregion
    }

}
