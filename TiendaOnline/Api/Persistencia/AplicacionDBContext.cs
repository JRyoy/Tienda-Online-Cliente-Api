using Microsoft.EntityFrameworkCore;
using Varios;

namespace Api.Persistencia;

public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions<AplicacionDbContext> opciones)
        : base(opciones)
    {}
    public DbSet<Carrito> Carritos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ItemCarrito> ItemCarritos { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }

    internal static void OnModelCreating()
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vendedor>().HasData(
                    new Vendedor("Rias", "Gremory", "kk@gmail.com", "delfin", "dsfsdfv"),
                    new Vendedor("Issei", "hyodo", "ññ@gmail.com", "delfin", "30851")
                );
        modelBuilder.Entity<Producto>().HasData(
            new Producto("Smartphone",120,5),
            new Producto("Laptop",150,5),
            new Producto("Televisor",200,5),
            new Producto("Manzanas", 2.49, 150),
            new Producto("Pan integral", 3.99, 200)      
                );
         modelBuilder.Entity<Cliente>().HasData(
            new Cliente("Juan", "Perez", "juanperez@example.com", "juanito123", "password123"),
            new Cliente("Ana", "Gomez", "anagomez@example.com", "anita456", "clave456"),
            new Cliente("Luis", "Rodriguez", "luisr@example.com", "lucho789", "pass789"),
            new Cliente("María", "Martínez", "mariam@example.com", "mari123", "contraseña123"),
            new Cliente("Carlos", "López", "carlosl@example.com", "carlitos1", "clave1234")
         );
         modelBuilder.Entity<Categoria>().HasData(
            new Categoria("Electrónica", "Productos electrónicos y gadgets"),
            new Categoria("Ropa", "Ropa de moda para todas las edades"),
            new Categoria("Alimentos", "Productos alimenticios y comestibles"),
            new Categoria("Hogar", "Artículos para el hogar y decoración"),
            new Categoria("Deportes", "Equipos y accesorios deportivos")
         );
    }
    
}
