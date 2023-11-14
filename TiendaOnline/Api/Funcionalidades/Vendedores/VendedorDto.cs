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
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Apodo { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public List<ProductoQueryDto> Productos { get; set; } = new List<ProductoQueryDto>();
}
