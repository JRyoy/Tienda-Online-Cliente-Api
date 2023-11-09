using Api.Funcionalidades.Productos;

namespace Api.Funcionalidades.Vendedores;

public class VendedorCommandDto
{

    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string Email { get; set; }
    public required string Apodo { get; set; }
    public required string Password { get; set; }
}
public class VendedorQueryDto
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Apodo { get; set; }
    public string Password { get; set; }
    public List<ProductoQueryDto> Productos { get; set; } = new List<ProductoQueryDto>();
}
