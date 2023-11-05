using Api.Funcionalidades.Carritos;
using Api.Funcionalidades.Categorias;
using Api.Funcionalidades.Clientes;
using Api.Funcionalidades.ItemCarritos;

using Api.Funcionalidades.Productos;
using Api.Funcionalidades.Vendedores;

namespace Api.Funcionalidades;

public static class ServiceManager
{
    public static IServiceCollection AddServiceManager(this IServiceCollection services)
    {
        services.AddScoped<IVendedorService, VendedorService>();
        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<IProductoService, ProductoService>();
        services.AddScoped<ICategoriaService, CategoriaService>();
        services.AddScoped<IItemCarritoService, ItemCarritoService>();
        services.AddScoped<ICarritoService, CarritoService>();
        return services;

    }
}
