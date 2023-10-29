using Microsoft.EntityFrameworkCore;
using Varios;

namespace Api.Persistencia;

public class AplicacionDBContext:DbContext
{
    public AplicacionDBContext(DbContextOptions<AplicacionDBContext> opciones)
        : base(opciones)
    {
        
    }
    public DbSet<Carrito>Carritos {get; set;}
    public DbSet<Categoria>Categorias {get; set;}
    public DbSet<Cliente>Clientes {get; set;}
    public DbSet<ItemCarrito>ItemCarritos {get; set;}
    public DbSet<Producto>Productos {get; set;}
    public DbSet<Vendedor>Vendedores {get; set;}


}
