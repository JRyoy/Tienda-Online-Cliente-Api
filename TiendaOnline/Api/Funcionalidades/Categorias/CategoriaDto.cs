using Api.Funcionalidades.Productos;

namespace Api.Funcionalidades.Categorias;

public class CategoriaDto
{
    public required string Nombre{get; set;}
    public required string Descripcion{get; set;}
    
}
public class CategoriaQueryDto
{   
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Nombre{get; set;}
    public required string Descripcion{get; set;}
    public List<ProductoQueryDto> Productos { get; set; } = new List<ProductoQueryDto>();

}
