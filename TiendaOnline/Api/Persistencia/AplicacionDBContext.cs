using Microsoft.EntityFrameworkCore;
using Varios;

namespace Api.Persistencia;

public class AplicacionDBContext : DbContext
{
    public AplicacionDBContext(DbContextOptions<AplicacionDBContext> opciones)
        : base(opciones)
    {}
    public DbSet<Carrito> Carritos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ItemCarrito> ItemCarritos { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vendedor>().HasData(
                    new Vendedor("Rias", "Gremory", "kk@gmail.com", "delfin", "dsfsdfv"),
                    new Vendedor("Issei", "hyodo", "ññ@gmail.com", "delfin", "30851")
                );
        modelBuilder.Entity<Categoria>().HasData(
                new Categoria ( "Electrónica", "Productos electrónicos y dispositivos." ),
                new Categoria (  "Ropa",  "Prendas de vestir y accesorios de moda." ),
                new Categoria ( "Alimentos",  "Productos alimenticios y comestibles."),
                new Categoria (  "Hogar", "Artículos para el hogar y muebles." ),
                new Categoria ( "Deportes",  "Equipos y artículos deportivos.")
                );

    }
    
}
