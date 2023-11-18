using Api.Funcionalidades.Productos;

namespace Api.Funcionalidades.Clientes;

public class ClienteCommandDto
{

    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string Email { get; set; }
    public required string Apodo { get; set; }
    public required string Password { get; set; }
}
public class ClienteQueryDto
{
    public Guid Id { get; set; } 
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Apodo { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public List<ProductoQueryDto> Productos { get; set; } = new List<ProductoQueryDto>();
}
