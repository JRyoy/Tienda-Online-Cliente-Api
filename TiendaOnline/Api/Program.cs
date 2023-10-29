using Api.Funcionalidades;
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
builder.Services.AddServiceManager();
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
