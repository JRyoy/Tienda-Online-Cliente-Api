using Api.Funcionalidades;
using Carter;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServiceManager();
builder.Services.AddCarter();

var connectionString = builder.Configuration.GetConnectionString("aplicacion_db");

builder.Services.AddDbContext<AplicacionDBContext>(opcion => opcion.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 34))));

var opciones = new DbContextOptionsBuilder<AplicacionDBContext>();

opciones.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 34)));

var contexto = new AplicacionDBContext(opciones.Options);

     contexto.Database.EnsureCreated();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapCarter();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
