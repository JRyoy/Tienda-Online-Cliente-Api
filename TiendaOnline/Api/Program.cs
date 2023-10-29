using Api.Funcionalidades.Carritos;
using Api.Funcionalidades.Categorias;
using Api.Funcionalidades.Clientes;
using Api.Funcionalidades.ItemCarritos;
using Api.Funcionalidades.Plataformas;
using Api.Funcionalidades.Productos;
using Api.Funcionalidades.Vendedores;
using Varios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton< IVendedorService,VendedorService>();
builder.Services.AddSingleton<IClienteService,ClienteService>();
builder.Services.AddSingleton<IProductoService,ProductoService>();
builder.Services.AddSingleton<IPlataformaService,PlataformaService>();
builder.Services.AddSingleton<ICategoriaService,CategoriaService>();
builder.Services.AddSingleton<IItemCarritoService,ItemCarritoService>();
builder.Services.AddSingleton<ICarritoService,CarritoService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.AddVendedorEndpoints();
app.AddClienteEndpoints();
app.AddProductoEndpoints();
app.AddPlataformaEndpoints();
app.AddCategoriaEndpoint();
app.AddItemCarritoEndpoints();
app.AddCarritoEndpoints();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
