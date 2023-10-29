using Api.Funcionalidades.Carritos;
using Api.Funcionalidades.Categorias;
using Api.Funcionalidades.Clientes;
using Api.Funcionalidades.ItemCarritos;
using Api.Funcionalidades.Plataformas;
using Api.Funcionalidades.Productos;
using Api.Funcionalidades.Vendedores;

namespace Api.Funcionalidades;

public static  class ServiceManager
{
    public static   IServiceCollection AddServiceManager(this IServiceCollection services)
    {
        services.AddSingleton< IVendedorService,VendedorService>();
        services.AddSingleton<IClienteService,ClienteService>();
        services.AddSingleton<IProductoService,ProductoService>();
        services.AddSingleton<IPlataformaService,PlataformaService>();
        services.AddSingleton<ICategoriaService,CategoriaService>();
        services.AddSingleton<IItemCarritoService,ItemCarritoService>();
        services.AddSingleton<ICarritoService,CarritoService>();

    return services;

    }
}
